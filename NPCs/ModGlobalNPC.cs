using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using StylishVanity.Items.Armor;

namespace StylishVanity.NPCs
{
	public class ModGlobalNPC : GlobalNPC
	{
		public override void SetupShop(int type, Chest shop, ref int nextSlot)
		{
			if (type == NPCID.GoblinTinkerer)
			{
				shop.item[nextSlot].SetDefaults(ModContent.ItemType<RoyalCrown>());
				nextSlot++;
			}
		}
	}
}