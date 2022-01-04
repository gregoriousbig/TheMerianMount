using TheMerianMount.Buffs;
using TheMerianMount.Dusts;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMerianMount.Mounts
{
	public class TheMerian : ModMountData
	{
		public override void SetDefaults() {
			mountData.buff = ModContent.BuffType<MerianBuff>();
			mountData.heightBoost = 0;
			mountData.fallDamage = 0f;
			mountData.runSpeed = 8f;
			mountData.dashSpeed = 0f;
			mountData.flightTimeMax = 320;
			mountData.fatigueMax = 320;
			mountData.jumpHeight = 5;
			mountData.acceleration = 1f;
			mountData.jumpSpeed = 4f;
			mountData.blockExtraJumps = true;
			mountData.totalFrames = 3;
			mountData.usesHover = true;
			int[] array = new int[mountData.totalFrames];
			for (int l = 0; l < array.Length; l++) {
				array[l] = 0;
			}
			mountData.playerYOffsets = array;
			mountData.xOffset = 0;
			mountData.bodyFrame = 0;
			mountData.yOffset = 0;
			mountData.playerHeadOffset = 0;
			mountData.standingFrameCount = 3;
			mountData.standingFrameDelay = 12;
			mountData.standingFrameStart = 0;
			mountData.runningFrameCount = 3;
			mountData.runningFrameDelay = 12;
			mountData.runningFrameStart = 0;
			mountData.flyingFrameCount = 3;
			mountData.flyingFrameDelay = 12;
			mountData.flyingFrameStart = 0;
			mountData.inAirFrameCount = 3;
			mountData.inAirFrameDelay = 12;
			mountData.inAirFrameStart = 0;
			mountData.idleFrameCount = 3;
			mountData.idleFrameDelay = 12;
			mountData.idleFrameStart = 0;
			mountData.idleFrameLoop = true;
			mountData.swimFrameCount = mountData.inAirFrameCount;
			mountData.swimFrameDelay = mountData.inAirFrameDelay;
			mountData.swimFrameStart = mountData.inAirFrameStart;
			if (Main.netMode == NetmodeID.Server) {
				return;
			}

			mountData.textureWidth = mountData.backTexture.Width;
			mountData.textureHeight = mountData.backTexture.Height;
		}


	}
}