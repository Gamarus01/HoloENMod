using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using HoloENMod.Tiles;


namespace HoloENMod.Items.Alloy.Armors
{
	[AutoloadEquip(EquipType.Head)]
	public class AlloyHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This is a modded helmet.");
			DisplayName.SetDefault("Alloy Helmet");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 20;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<AlloyBreastplate>() && legs.type == ModContent.ItemType<AlloyLeggings>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "+20% all damage, +40 max hp";
			player.allDamage += 0.2f;
			player.statLifeMax2 += 40;
			/* Here are the individual weapon class bonuses.
			player.meleeDamage -= 0.2f;
			player.thrownDamage -= 0.2f;
			player.rangedDamage -= 0.2f;
			player.magicDamage -= 0.2f;
			player.minionDamage -= 0.2f;
			*/
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<AlloyBar>(), 30);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
