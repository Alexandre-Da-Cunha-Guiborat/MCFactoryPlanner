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
    internal class IronOreToIngotFurnaceRecipe : IRecipe
    {
        #region Public

        public IRecipeId Id { get; }

        public IEnumerable<IRecipeInput> Inputs { get; }

        public IEnumerable<IRecipeOutput> Outputs { get; }

        public IRecipeProcess Process { get; }

        public Boolean IsHidden { get; }

        public Dictionary<string, object> Metadata { get; }

        public IronOreToIngotFurnaceRecipe(IEnumerable<IResource> resources)
        {
            Id = new RecipeId(_id, _mod, _displayName);

            IResource ironOre = resources.First(r => r is IronOre);
            IResource ironIngot = resources.First(r => r is IronIngot);

            IRecipeInput ironOreInput = new RecipeInput(ironOre, 1u, 1d, []);
            IRecipeOutput ironIngotOutput = new RecipeOutput(ironIngot, 1u, 1d, []);

            IProcessor furnace = new Furnace();
            IEnergy energy = new FuelEnergy(200);
            IRecipeProcess ironOreToIronIngotProcess = new RecipeProcess(furnace, (20u * 60u), energy, []);

            Inputs = [ironOreInput];
            Outputs = [ironIngotOutput];
            Process = ironOreToIronIngotProcess;
            IsHidden = false;
            Metadata = [];
        }

        #endregion Public

        #region Private

        private static String _id => $"{_mod}_{_displayName}";
        private static String _mod = $"minecraft";
        private static String _displayName = $"{nameof(IronOreToIngotFurnaceRecipe)}";

        #endregion Private
    }
}
