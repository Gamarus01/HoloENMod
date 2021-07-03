using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace HoloENMod.Items.Hololite
{
    public class HololiteOre : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;

            item.maxStack = 999;
            item.value = Item.buyPrice(silver: 5);
            item.rare = ItemRarityID.Blue;
            item.consumable = true;

            item.useTime = 12;
            item.useAnimation = 12;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTurn = true;
            item.autoReuse = true;

            item.createTile = ModContent.TileType<Tiles.Hololite.HololiteOre>();
        }
    }
}
