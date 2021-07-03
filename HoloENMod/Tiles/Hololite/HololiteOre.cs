using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace HoloENMod.Tiles.Hololite
{
    public class HololiteOre : ModTile
    {
        public override void SetDefaults() 
        {
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileMergeDirt[Type] = true;

            drop = ModContent.ItemType<Items.Hololite.HololiteOre>();

            AddMapEntry(Microsoft.Xna.Framework.Color.Purple);

        }
    }
}

