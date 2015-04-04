using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Design;

using TAPI;
using Terraria;

namespace ConversionMod.Buffs
{
    class RedPlague : ModBuff
    {
        public override void Effects(NPC npc, int index)
        {
            npc.color = Color.Crimson;
        }
        public override void End(NPC npc, int index)
        {
            int radius = 5;
            npc.HitEffect(0, 200);
            npc.color = default(Color);

            foreach (NPC element in Main.npc)
            {
                for (float particlesX = -5; particlesX <= 5; particlesX += 0.1f)
                {
                    for (float particlesY = -5; particlesY <= 5; particlesY += 0.1f)
                    {
                        if (Math.Sqrt(Math.Abs((double)(npc.position.X - element.position.X) * (double)(npc.position.X - element.position.X) + (double)(npc.position.Y - element.position.Y) * (double)(npc.position.Y - element.position.Y))) <= radius && element.netID != npc.netID)
                        {
                            Dust.NewDust(new Vector2(npc.position.X + particlesX, npc.position.Y + particlesY), Vector2.One, 5);
                            element.AddBuff(BuffDef.byName["ConversionMod:Red Plague"], 600, true);
                        }
                    }
                }
            }
        }
    }
}
