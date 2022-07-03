using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StylishVanity.Items.Accessories
{
	public class PinkBalloon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("TirzahTheWhale's Pink Balloon");
			Tooltip.SetDefault("A balloon dedicated to TirzahTheWhale.");
		}
		public override void SetDefaults()
		{
			Item.width = 18;
			Item.height = 32;
			Item.value = 17000; // 1 Gold 70 Silver
			Item.rare = ItemRarityID.Blue;
			// item.vanity = true;
			Item.holdStyle = 1; // When selected hold like torches
			Item.accessory = true;
		}
		public override bool CanUseItem(Player player)
		{
			return false;
		}
		public override void HoldItem(Player player)
		{
			player.itemLocation.X = player.Center.X - 2 * player.direction; // Align item to player's hand
		}
		/**
		 * @todo Visual for accessories
		 * @body Add visual for the balloons when equipped
		 */
		/**
		 * @todo Lower jump in water
		 * @body Like shiny red balloon
		 */
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.jumpBoost = true;
			player.jumpSpeedBoost += 0.1f;
        }
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.ShinyRedBalloon);
			recipe.AddIngredient(ItemID.PinkPricklyPear);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
		}
	}
}