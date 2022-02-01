using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace HoloENMod.Tiles.Hololite
{
    public class HololiteOreTile : ModTile
    {
        public override void SetDefaults() 
        {
            TileID.Sets.Ore[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileSpelunker[Type] = true;
            minPick = 65;
            mineResist = 3f;

            drop = ModContent.ItemType<Items.Hololite.HololiteOre>();

            AddMapEntry(Microsoft.Xna.Framework.Color.Purple);

        }
    }
}

