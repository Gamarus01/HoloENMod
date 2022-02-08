using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace HoloENMod.Items.Hololite.Weapons
{
    public class HololiteStaff : ModItem
    {

        public override void SetStaticDefaults()
        {
            Item.staff[item.type] = true;
        }
        public override void SetDefaults()
        {
            item.Size = new Vector2(40);

            item.magic = true;
            item.mana = 4;
            item.damage = 25;
            item.knockBack = 2f;
            item.crit = 10;
            item.noMelee = true;

            item.useTime = 23;
            item.useAnimation = 23;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.UseSound = SoundID.Item43;

            item.shoot = ModContent.ProjectileType<Projectiles.HololiteBolt>();
            item.shootSpeed = 10.00f;
            item.autoReuse = true;

            item.value = Item.buyPrice(silver: 10);
            item.rare = ItemRarityID.Blue;
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ModContent.ItemType<HololiteBar>(), 12);
            r.AddTile(TileID.Anvils);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}