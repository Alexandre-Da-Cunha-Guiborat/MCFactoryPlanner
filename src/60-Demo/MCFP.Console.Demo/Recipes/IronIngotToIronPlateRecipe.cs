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
    internal class IronIngotToIronPlateRecipe : IRecipe
    {
        #region Public

        public IRecipeId Id { get; }

        public IEnumerable<IRecipeInput> Inputs { get; }

        public IEnumerable<IRecipeOutput> Outputs { get; }

        public IRecipeProcess Process { get; }

        public Boolean IsHidden { get; }

        public Dictionary<string, object> Metadata { get; }

        public IronIngotToIronPlateRecipe(IEnumerable<IResource> resources)
        {
            Id = new RecipeId(_id, _mod, _displayName);

            IResource ironIngot = resources.First(r => r is IronIngot);
            IResource ironPlate = resources.First(r => r is IronPlate);

            IRecipeInput ironIngotInput = new RecipeInput(ironIngot, 1u, 1d, []);
            IRecipeOutput ironPlateOutput = new RecipeOutput(ironPlate, 1u, 1d, []);

            IProcessor bender = new BenderLV();
            IEnergy energy = new EuEnergy(1344);
            IRecipeProcess ironIngotToIronPlateProcess = new RecipeProcess(bender, 56u, energy, new Dictionary<string, object> { { "CircuitNb", 1 } });

            Inputs = [ironIngotInput];
            Outputs = [ironPlateOutput];
            Process = ironIngotToIronPlateProcess;
            IsHidden = false;
            Metadata = [];
        }

        #endregion Public

        #region Private

        private static String _id => $"{_mod}_{_displayName}";
        private static String _mod = $"minecraft";
        private static String _displayName = $"{nameof(IronIngotToIronPlateRecipe)}";

        #endregion Private
    }
}
