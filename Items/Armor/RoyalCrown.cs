using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace StylishVanity.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class RoyalCrown : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Royal Crown");
			ArmorIDs.Head.Sets.DrawFullHair[Item.headSlot] = true;
		}
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 22;
			Item.value = 10000; // 1 Gold
			Item.rare = ItemRarityID.Orange;
			Item.vanity = true;
		}
		public override bool CanUseItem(Player player)
		{
			return false;
		}
		public override void EquipFrameEffects(Player player, EquipType type)
		{
			// Spawn dust 1/10 of the time
			if (Main.rand.Next(10) == 0) {
				Dust.NewDust(player.position, player.width, player.height, DustID.Firework_Yellow);
			}
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldBar, 15);
			recipe.AddIngredient(ItemID.Ruby);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}