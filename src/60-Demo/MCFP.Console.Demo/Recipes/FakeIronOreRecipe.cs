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
    internal class FakeIronOreRecipe : IRecipe
    {
        #region Public

        public IRecipeId Id { get; }

        public IEnumerable<IRecipeInput> Inputs { get; }

        public IEnumerable<IRecipeOutput> Outputs { get; }

        public IRecipeProcess Process { get; }

        public Boolean IsHidden { get; }

        public Dictionary<string, object> Metadata { get; }

        public FakeIronOreRecipe(IEnumerable<IResource> resources)
        {
            Id = new RecipeId(_id, _mod, _displayName);

            IResource ironOre = resources.First(r => r is IronOre);
            IRecipeOutput ironOreOutput = new RecipeOutput(ironOre, uint.MaxValue, 1d, []);

            IProcessor fake = new FakeProcessor();
            IEnergy energy = new NoEnergy();
            IRecipeProcess ironOreProcess = new RecipeProcess(fake, 0u, energy, []);

            Inputs = [];
            Outputs = [ironOreOutput];
            Process = ironOreProcess;
            IsHidden = true;
            Metadata = [];
        }

        #endregion Public

        #region Private

        private static String _id => $"{_mod}_{_displayName}";
        private static String _mod = $"minecraft";
        private static String _displayName = $"{nameof(FakeIronOreRecipe)}";

        #endregion Private
    }
}
