using System;
using System.Collections.Generic;
using System.Linq;
using MCFP.Common.Interfaces;
using MCFP.Console.Demo.EnergyGenerator;
using MCFP.Console.Demo.Mod.Vanilla.Recipes;
using MCFP.Console.Demo.Resources;

internal class Program
{
    private static void Main(string[] args)
    {
        Calcultator(args);
    }

    private static void Calcultator(string[] args)
    {
        List<IResource> resources = [new Charcoal(), new Chest(), new CreosoteOil(), new IronIngot(), new IronOre(), new IronPlate(), new OakLog(), new OakPlank()];


        IRecipe woodRecipe = new FakeWoodRecipe(resources);
        FactoryComponent woodProduction = new FactoryComponent("woodProduction", woodRecipe, [], [], []);

        IRecipe ironOreRecipe = new FakeIronOreRecipe(resources);
        FactoryComponent ironOreProduction = new FactoryComponent("ironOreProduction", ironOreRecipe, [], [], []);

        IRecipe woodToCharcoalCokeOvenRecipe = new WoodToCharcoalCokeOvenRecipe(resources);
        Dictionary<IRecipeOutput, IRecipeInput> charcoalProductionRecipeMappings = new Dictionary<IRecipeOutput, IRecipeInput>() { { woodProduction.Recipe.Outputs.First(), woodToCharcoalCokeOvenRecipe.Inputs.First() } };
        FactoryComponent charcoalProduction = new FactoryComponent("charcoalProduction", woodToCharcoalCokeOvenRecipe, [woodProduction], charcoalProductionRecipeMappings, []);

        IRecipe ironOreToIngotFurnaceRecipe = new IronOreToIngotFurnaceRecipe(resources);
        FuelGenerator fuelGenerator = new FuelGenerator([charcoalProduction]);
        Dictionary<IRecipeOutput, IRecipeInput> ironIngotProductionRecipeMappings = new Dictionary<IRecipeOutput, IRecipeInput>() { { ironOreProduction.Recipe.Outputs.First(), ironOreToIngotFurnaceRecipe.Inputs.First() } };
        Dictionary<IRecipeOutput, IEnergyGenerator> ironIngotProductionGeneratorMappings = new Dictionary<IRecipeOutput, IEnergyGenerator>() { { charcoalProduction.Recipe.Outputs.First(), fuelGenerator } };
        FactoryComponent ironIngotProduction = new FactoryComponent("ironIngotProduction", ironOreToIngotFurnaceRecipe, [ironOreProduction, charcoalProduction], ironIngotProductionRecipeMappings, [fuelGenerator]);

        IRecipe ironPlateRecipe = new IronIngotToIronPlateRecipe(resources);
        EuGenerator euGenerator = new EuGenerator([charcoalProduction]);
        Dictionary<IRecipeOutput, IRecipeInput> ironPlateProductionRecipeMappings = new Dictionary<IRecipeOutput, IRecipeInput>() { { ironIngotProduction.Recipe.Outputs.First(), ironPlateRecipe.Inputs.First() } };
        Dictionary<IRecipeOutput, IEnergyGenerator> ironPlateProductionGeneratorMappings = new Dictionary<IRecipeOutput, IEnergyGenerator>() { { charcoalProduction.Recipe.Outputs.Last(), euGenerator } };
        FactoryComponent ironPlateProduction = new FactoryComponent("ironPlateProduction", ironPlateRecipe, [ironIngotProduction, charcoalProduction], ironPlateProductionRecipeMappings, [euGenerator]);

        Factory ironPlateFactory = new Factory("ironPlateFactory", [woodProduction, charcoalProduction, ironOreProduction, ironIngotProduction, ironPlateProduction]);

        Test(woodProduction);
        Test(ironOreProduction);
        Test(charcoalProduction);
        Test(ironIngotProduction);
        Test(ironPlateProduction);

        SummaryBis(ironPlateFactory);
    }

    private static void Test(FactoryComponent factoryComponent)
    {
        IEnumerable<(String resource, Single ratio)> recipeRatios = factoryComponent.InputsToRecipeInputsMapping.Select(m => (m.Key.Resource.Id.Id, (Single)m.Key.Amount / m.Value.Amount));
        IEnumerable<String> recipeRatiosPrintable = recipeRatios.Select(r => $"{r.resource} : {r.ratio}");
        Console.WriteLine($"[{String.Join(',', recipeRatiosPrintable)}]");
    }

    private static void SummaryBis(Factory factory)
    {
        Dictionary<IResourceId, (UInt64 amountIn, UInt64 amountOut)> resourceRatioInOut = [];
        foreach (FactoryComponent component in factory.Components)
        {
            foreach (IRecipeInput input in component.Recipe.Inputs)
            {
                if (resourceRatioInOut.ContainsKey(input.Resource.Id))
                {
                    (UInt64 amountIn, UInt64 amountOut) ratio = resourceRatioInOut[input.Resource.Id];
                    ratio.amountIn += input.Amount;
                    resourceRatioInOut[input.Resource.Id] = ratio;
                }
                else
                {
                    resourceRatioInOut.Add(input.Resource.Id, (input.Amount, 0));
                }
            }

            foreach (IRecipeOutput output in component.Recipe.Outputs)
            {
                if (resourceRatioInOut.ContainsKey(output.Resource.Id))
                {
                    (UInt64 amountIn, UInt64 amountOut) ratio = resourceRatioInOut[output.Resource.Id];
                    ratio.amountOut += output.Amount;
                    resourceRatioInOut[output.Resource.Id] = ratio;
                }
                else
                {
                    resourceRatioInOut.Add(output.Resource.Id, (0, output.Amount));
                }
            }
        }

        Dictionary<IResourceId, IEnergy> generatedEnergies = [];
        IEnumerable<IEnergyGenerator> generators = factory.Components.SelectMany(c => c.EnergyGenerators);
        foreach (IEnergyGenerator generator in generators)
        {
            foreach (IFactoryComponent genInput in generator.Inputs)
            {
                IEnumerable<(IResource resource, UInt64 Amount)> resourceInput = genInput.Recipe.Outputs.Select(o => (o.Resource, o.Amount));
                IEnumerable<(IResourceId resourceId, IEnergy energy)> generated = resourceInput.Select(rInput => (rInput.resource.Id, generator.GenerateEnergy(rInput.resource, rInput.Amount)));

                foreach ((IResourceId resourceId, IEnergy energy) gen in generated)
                {
                    if (generatedEnergies.ContainsKey(gen.resourceId))
                    {
                        generatedEnergies[gen.resourceId] = gen.energy; // ! TODO : This is wrong in it self. Need to sum up the total energy produced
                    }
                    else
                    {
                        generatedEnergies.Add(gen.resourceId, gen.energy);
                    }
                }

            }
        }

        List<String> resourceRatioPrintable = [];
        foreach (KeyValuePair<IResourceId, (UInt64 amountIn, UInt64 amountOut)> r in resourceRatioInOut)
        {
            resourceRatioPrintable.Add($"{r.Key} : {(Single)r.Value.amountOut} / {r.Value.amountIn}");
        }

        foreach (KeyValuePair<IResourceId, IEnergy> g in generatedEnergies)
        {
            resourceRatioPrintable.Add($"{g.Key} : {g.Value.TotalEnergy}");
        }
        Console.WriteLine($"[{String.Join(", ", resourceRatioPrintable)}]");
    }
}
