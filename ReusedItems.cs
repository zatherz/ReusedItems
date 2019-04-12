using System;
using Semi;
using Logger = ModTheGungeon.Logger;

namespace ReusedItems {
	public class ReusedItems : Mod {
		internal static Logger Logger = new Logger("ReusedItems");

		public override void Loaded() {
			Logger.Info($"Loaded");
		}

		public override void RegisterContent() {
			Logger.Info($"Registering content");

			RegisterEncounterIcon("brittle_bullet", "gfx/brittle_bullet.png");

			var def = CreateSpriteDefinition("brittle_bullet", "gfx/brittle_bullet.png");
			var coll = RegisterSpriteCollection(
				"item_sprites",
				def
			);

			var sprite = RegisterSpriteTemplate(
				"brittle_bullet_sprite",
				"reused_items:item_sprites",
				"reused_items:brittle_bullet"
			);

			var it = RegisterItem<FragileGunItem>(
				"brittle_bullet",
				"reused_items:brittle_bullet",
				"reused_items:brittle_bullet_sprite",
				"#BRITTLEBULLET_ENCNAME",
				"#BRITTLEBULLET_SHORTDESC",
				"#BRITTLEBULLET_LONGDESC"
			);

			it.GunPiecePrefab = Gungeon.Items["gungeon:gun_piece"].gameObject;
		}
	}
}
