using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StylishVanity.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class PinkTopHat : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("TirzahTheWhale's Pink Top Hat");
			Tooltip.SetDefault("A top hat dedicated to TirzahTheWhale.");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 14;
			item.value = 4000; // 40 Silver
			item.rare = 1; // Blue
			item.vanity = true;
		}
		public override bool CanUseItem(Player player)
		{
			return false;
		}
		/*
		public override void UpdateVanity(Player player, EquipType type)
		{}
		*/
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TopHat);
			recipe.AddIngredient(ItemID.PinkPricklyPear);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}