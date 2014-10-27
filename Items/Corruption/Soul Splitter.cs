using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria;
using TAPI;

namespace ConversionMod
{
    class SoulSplitter : ModItem
    {
        public override void OnHitNPC(Player owner, NPC victim, Vector2 hitLocation)
        {
            if (victim.life <= 0)
            {
                Dust.NewDust(hitLocation, Main.rand.NextVector2(-5, 5), 0 /* todo */);
            }
        }
    }
}
