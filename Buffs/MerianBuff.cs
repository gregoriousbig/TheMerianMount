using Terraria;
using Terraria.ModLoader;

namespace TheMerianMount.Buffs
{
	public class MerianBuff : ModBuff
	{
				
		public override void SetDefaults() {
			DisplayName.SetDefault("Merian's blessing");
			Description.SetDefault("Fly like a butterfly, but you're squishy!");
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
			Main.debuff[Type] = false; //Add this so the nurse doesn't remove the buff when healing
		}

		public override void Update(Player player, ref int buffIndex) {
			player.mount.SetMount(ModContent.MountType<Mounts.TheMerian>(), player);
			player.buffTime[buffIndex] = 10;
			player.noFallDmg = true;
            player.mount._flyTime = 100;
            player.statDefense -= 999;		//Removes defense
			player.statLifeMax2 = 20;
        }	
	}
}
