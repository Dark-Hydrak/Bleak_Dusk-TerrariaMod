using Terraria.ID;
using Terraria.ModLoader;

namespace BleakDusk.Items
{
	public class flesh_rotting_scythe : ModItem
	{
        private const bool V = true;

        public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("BasicSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is a basic modded sword.");
		}

		public override void SetDefaults()
		{
			item.damage = 666;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 50;
			item.useAnimation = 50;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 66;
			item.value = 666;
			item.rare = ItemRarityID.Red;
			item.UseSound = SoundID.Item22;
            item.autoReuse = true;
			
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