using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Threading;

using Terraria;
using TAPI;
using Microsoft.Xna.Framework;

namespace ConversionMod
{
    class SoulSplitter : ModItem
    {
        public override void OnHitNPC(Player owner, NPC victim, Vector2 hitLocation)
        {
            if (victim.life <= 0)
            {
                Dust.NewDust(hitLocation, Main.rand.NextVector2(-5, 5), );
            }
        }
    }
}
