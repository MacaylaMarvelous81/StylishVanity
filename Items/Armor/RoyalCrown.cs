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
			item.width = 30;
			item.height = 22;
			item.value = 10000; // 1 Gold
			item.rare = ItemRarityID.Orange;
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
				/*
				 * @todo Update to DustID
				 * @body Update to DustID if tmodLoader/tModLoader$1343 is merged and tModLoader updates to 1.4
				*/
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