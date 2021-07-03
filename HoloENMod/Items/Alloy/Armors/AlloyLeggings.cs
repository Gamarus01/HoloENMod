using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using HoloENMod.Tiles;

namespace HoloENMod.Items.Alloy.Armors
{
	[AutoloadEquip(EquipType.Legs)]
	public class AlloyLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This is a modded leg armor."
				+ "\n5% increased movement speed");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 45;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.05f;
		}

		public override void AddRecipes()
		{
			ModRecipe r = new ModRecipe(mod);
			r.AddIngredient(ModContent.ItemType<AlloyBar>(), 30);
			r.AddTile(TileID.Anvils);
			r.SetResult(this);
			r.AddRecipe();
		}
	}
}
