using System;
using System.Collections.Generic;
using System.Linq;
using MCFP.Common.Interfaces;
using MCFP.Common.Model;
using MCFP.Console.Demo.Energies;
using MCFP.Console.Demo.Processors;
using MCFP.Console.Demo.Resources;

namespace MCFP.Console.Demo.Mod.Vanilla.Recipes
{
    internal class WoodToCharcoalCokeOvenRecipe : IRecipe
    {
        #region Public

        public IRecipeId Id { get; }

        public IEnumerable<IRecipeInput> Inputs { get; }

        public IEnumerable<IRecipeOutput> Outputs { get; }

        public IRecipeProcess Process { get; }

        public Boolean IsHidden { get; }

        public Dictionary<string, object> Metadata { get; }

        public WoodToCharcoalCokeOvenRecipe(IEnumerable<IResource> resources)
        {
            Id = new RecipeId(_id, _mod, _displayName);

            IResource oakLog = resources.First(r => r is OakLog);
            IResource charcoal = resources.First(r => r is Charcoal);
            IResource creosoteOil = resources.First(r => r is CreosoteOil);

            IRecipeInput oakLogInput = new RecipeInput(oakLog, 1u, 1d, []);
            IRecipeOutput charcoalOutput = new RecipeOutput(charcoal, 1u, 1d, []);
            IRecipeOutput creosoteOilOutput = new RecipeOutput(creosoteOil, 250u, 1d, []);

            IProcessor cokeOven = new CokeOven();
            IEnergy energy = new NoEnergy();
            IRecipeProcess woodToCharcoalCokeOvenProcess = new RecipeProcess(cokeOven, (1800u), energy, []);

            Inputs = [oakLogInput];
            Outputs = [charcoalOutput, creosoteOilOutput];
            Process = woodToCharcoalCokeOvenProcess;
            IsHidden = false;
            Metadata = [];
        }

        #endregion Public

        #region Private

        private static String _id => $"{_mod}_{_displayName}";
        private static String _mod = $"minecraft";
        private static String _displayName = $"{nameof(WoodToCharcoalCokeOvenRecipe)}";

        #endregion Private
    }
}
