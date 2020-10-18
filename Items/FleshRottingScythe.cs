using Terraria.ID;
using Terraria.ModLoader;
using BleakDusk.Buffs;
using BleakDusk.NPCs;

namespace BleakDusk.Items
{
	public class FleshRottingScythe : ModItem
	{
        private const bool V = true;

        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flesh Rotting Scythe");
			Tooltip.SetDefault("This is a basic modded sword.");
		}

		public override void SetDefaults()
		{
			item.damage = 3;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 5;
			item.useAnimation = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 5;
			item.value = 666;
			item.rare = ItemRarityID.Red;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;
			
		}

		// We hit the NPC
		public override void OnHitNPC(Terraria.Player player, Terraria.NPC target, int damage, float knockBack, bool crit)
        {
			// Is the NPC a town NPC? (friendly)
			if (target.friendly == false)
            {
				// It's an enemy, apply debuffs to it
                target.AddBuff(mod.BuffType("Plagueblight"), 300);
				target.GetGlobalNPC<NPCsGlobal>().plagueDamage += damage;
			}
        }
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}