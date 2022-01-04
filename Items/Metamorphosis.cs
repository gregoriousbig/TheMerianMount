using TheMerianMount.Mounts;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMerianMount.Items
{
	public class Metamorphosis : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Summons The Merian Mount, in the spirit of Maria Sibylla Merian, a true butterfly expert!");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = 30000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item79;
			item.noMelee = true;
			item.mountType = ModContent.MountType<TheMerian>();
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(Terraria.ID.ItemID.MonarchButterfly, 1);
            recipe.AddIngredient(Terraria.ID.ItemID.PurpleEmperorButterfly, 1);
			recipe.AddIngredient(Terraria.ID.ItemID.RedAdmiralButterfly, 1);
			recipe.AddIngredient(Terraria.ID.ItemID.UlyssesButterfly, 1);
			recipe.AddIngredient(Terraria.ID.ItemID.SulphurButterfly, 1);
			recipe.AddIngredient(Terraria.ID.ItemID.TreeNymphButterfly, 1);
			recipe.AddIngredient(Terraria.ID.ItemID.ZebraSwallowtailButterfly, 1);
			recipe.AddIngredient(Terraria.ID.ItemID.JuliaButterfly, 1);
			recipe.AddIngredient(Terraria.ID.ItemID.GoldButterfly, 1);
            recipe.AddTile(Terraria.ID.TileID.WorkBenches);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
		}
	}
}