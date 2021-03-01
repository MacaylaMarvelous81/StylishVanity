using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace StylishVanity.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class RoyalCrown : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Royal Crown");
			Tooltip.SetDefault("For royalty!");
		}
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 22;
			item.value = 10000; // 1 Gold
			item.rare = 2; // Orange
			item.vanity = true;
		}
		public override bool CanUseItem(Player player)
		{
			return false;
		}
		public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
		{
			drawHair = true;
		}
		public override void UpdateVanity(Player player, EquipType type)
		{
			// TODO: Spawn dust with the whole set
			// Spawn dust 1/10 of the time
			if (Main.rand.Next(10) == 0) {
				Dust.NewDust(player.position, player.width, player.height, 133);
			}
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 15);
			recipe.AddIngredient(ItemID.Ruby);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}