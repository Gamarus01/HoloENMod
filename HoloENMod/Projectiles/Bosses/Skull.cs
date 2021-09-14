using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HoloENMod.Projectiles.Bosses
{
	public class Skull : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Skull");
		}

		public override void SetDefaults()
		{
			projectile.width = 210;
			projectile.height = 330;
			projectile.aiStyle = 1;
			projectile.friendly = false;
			projectile.hostile = true;
			projectile.magic = true;
			projectile.timeLeft = 10;
			projectile.ignoreWater = true;
			projectile.tileCollide = false;
		}

		// Additional hooks/methods here.
	}
}