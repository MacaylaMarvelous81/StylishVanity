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
		public override void DrawHair(ref bool drawHair, ref bool drawAltHair)/* tModPorter Note: Removed. In SetStaticDefaults, use ArmorIDs.Head.Sets.DrawFullHair[Item.headSlot] = true if you had drawHair set to true, and ArmorIDs.Head.Sets.DrawHatHair[Item.headSlot] = true if you had drawAltHair set to true */
		{
			drawHair = true;
		}
		/*
		public override bool IsVanitySet(int head, int body, int legs)
		{
			Item headItem = new Item();
			Item bodyItem = new Item();
			Item legItem = new Item();
			if (head >= 0)
			{
				headItem.SetDefaults(Item.headType[head], true);
			}
			if (body >= 0)
			{
				bodyItem.SetDefaults(Item.bodyType[body], true);
			}
			if (legs >= 0)
			{
				legItem.SetDefaults(Item.legType[legs], true);
			}
			return headItem.type == ModContent.ItemType<RoyalCrown>() && bodyItem.type == ModContent.ItemType<RoyalCapeTop>() && legItem.type == ModContent.ItemType<RoyalCapeBottom>();
		}
		*/
		/*
		public override void UpdateVanitySet(Player player)
		{
			// Spawn dust 1/10 of the time
			if (Main.rand.Next(10) == 0)
			{
				// TODO: Update to DustID if tModLoader/tModLoader#1343 gets merged
				Dust.NewDust(player.position, player.width, player.height, 133);
			}
		}
		*/
		public override void UpdateVanity(Player player, EquipType type)
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