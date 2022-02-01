using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.World.Generation;
using Terraria.GameContent.Generation;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using System.Collections.Generic;

namespace HoloENMod
{
    public class HoloWorld : ModWorld
    {

        #region GENERATION
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int shiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (shiniesIndex != -1)
            {
                tasks.Insert(shiniesIndex + 1, new PassLegacy("Hololite Ore Spawn", GenerateHololiteOre));
            }
        }

        private void GenerateHololiteOre(GenerationProgress progress)
        {
            progress.Message = "Spawning Hololite Ore";
            for (var i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); i++)
            {
                int x = WorldGen.genRand.Next(200, Main.maxTilesX - 200);
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY - 275);

                WorldGen.TileRunner(x, y, WorldGen.genRand.Next(6, 14), WorldGen.genRand.Next(4, 12), ModContent.TileType<Tiles.Hololite.HololiteOreTile>());
            }
        }

        #endregion
    }
}
