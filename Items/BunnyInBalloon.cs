using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StylishVanity.Items
{
	public class BunnyInBalloon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bunny in a Balloon");
			Tooltip.SetDefault("How dare you!");
		}
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 32;
			item.value = 5500; // 55 Silver
			item.rare = 1; // Blue
			item.vanity = true;
			item.holdStyle = 1; // When selected hold like torches
		}
		public override bool CanUseItem(Player player)
		{
			return false;
		}
		public override void HoldItem(Player player)
		{
			// TODO: Increase jump height like Shiny Red Balloon
			player.itemLocation.X = player.Center.X - 2 * player.direction; // Align item to player's hand
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ShinyRedBalloon);
			recipe.AddIngredient(ItemID.Bunny);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}