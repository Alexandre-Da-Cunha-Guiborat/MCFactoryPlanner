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
    internal class OakLogToOakPlankRecipe : IRecipe
    {
        #region Public

        public IRecipeId Id { get; }

        public IEnumerable<IRecipeInput> Inputs { get; }

        public IEnumerable<IRecipeOutput> Outputs { get; }

        public IRecipeProcess Process { get; }

        public Boolean IsHidden { get; }

        public Dictionary<string, object> Metadata { get; }

        public OakLogToOakPlankRecipe(IEnumerable<IResource> resources)
        {
            Id = new RecipeId(_id, _mod, _displayName);

            IResource oakLog = resources.First(r => r is OakLog);
            IResource oakPlanks = resources.First(r => r is OakPlank);

            IRecipeInput oakLogInput = new RecipeInput(oakLog, 1u, 1d, []);
            IRecipeOutput oakPlanksOutput = new RecipeOutput(oakPlanks, 4u, 1d, []);

            IProcessor craftingTable = new CraftingTable();
            IEnergy energy = new NoEnergy();
            IRecipeProcess oakLogToOakPlankProcess = new RecipeProcess(craftingTable, 0u, energy, []);

            Inputs = [oakLogInput];
            Outputs = [oakPlanksOutput];
            Process = oakLogToOakPlankProcess;
            IsHidden = false;
            Metadata = [];
        }

        #endregion Public

        #region Private

        private static String _id => $"{_mod}_{_displayName}";
        private static String _mod = $"minecraft";
        private static String _displayName = $"{nameof(OakLogToOakPlankRecipe)}";

        #endregion Private
    }
}
