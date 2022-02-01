using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace HoloENMod.Projectiles.Bosses
{
	public class BigSlash : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("BigSlash");
		}

		public override void SetDefaults()
		{
			projectile.width = 356;
			projectile.height = 220;
			projectile.friendly = false;
			projectile.hostile = true;
			projectile.melee = true;
			projectile.timeLeft = 10;
			projectile.ignoreWater = true;
			projectile.tileCollide = false;
		}

		public override void AI()
		{
			projectile.rotation = projectile.velocity.ToRotation();
		}
	}
}


