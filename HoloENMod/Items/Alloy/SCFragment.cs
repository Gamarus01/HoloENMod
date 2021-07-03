using Terraria;
using Terraria.ModLoader;
using Terraria.ID;


namespace HoloENMod.Items.Alloy
{ 
     public class SCFragment : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;

            item.maxStack = 999;
            item.value = Item.buyPrice(silver: 5);
            item.rare = ItemRarityID.Blue;
            item.consumable = true;
        }
    } 
}
