using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using HoloENMod.Tiles;

namespace HoloENMod.Items.Hololite.Armors
{
	[AutoloadEquip(EquipType.Legs)]
	public class HololiteLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hololite Leggings");
			Tooltip.SetDefault("\n5% increased movement speed");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 7;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.05f;
		}

		public override void AddRecipes()
		{
			ModRecipe r = new ModRecipe(mod);
			r.AddIngredient(ModContent.ItemType<HololiteBar>(), 30);
			r.AddTile(TileID.Anvils);
			r.SetResult(this);
			r.AddRecipe();
		}
	}
}
