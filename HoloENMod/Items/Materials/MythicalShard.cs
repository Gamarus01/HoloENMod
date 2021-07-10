using Terraria.ID;
using Terraria.ModLoader;

namespace HoloENMod.Items.Materials
{
    public class MythicalShard : ModItem

    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mythical Shard");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 27;
            item.maxStack = 999;
            item.value = 200;
            item.rare = ItemRarityID.Blue;
        }
    }
}
