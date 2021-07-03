using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HoloENMod.Items.Consumables

{
	public class Asacoco : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Limited edition Asacoco! Extra strong");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 26;
			item.useStyle = ItemUseStyleID.EatingUsing;
			item.useAnimation = 17;
			item.useTime = 17;
			item.useTurn = true;
			item.UseSound = SoundID.Item3;
			item.maxStack = 30;
			item.consumable = true;
			item.rare = ItemRarityID.Orange;
			item.buffType = 156;
			item.buffTime = 600;
			item.value = Item.buyPrice(gold: 1);
		}

		
	}
}