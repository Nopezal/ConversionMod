using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria;
using TAPI;

namespace ConversionMod.Projectiles
{
    public sealed class CremenisialCreature : ModProjectile
    {
        Projectile p
        {
            get
            {
                return projectile;
            }
        }

        public override void AI()
        {
            float timer = 240;

            foreach (NPC element in Main.npc)
            {
                Vector2 oldVel = element.velocity;

                for (int i = 0; i < timer; i++)
                {
                    if (i == timer)
                        Projectile.NewProjectile(p.position, oldVel, "ConversionMod:SpikeballOfFlesh", 76, 1, p.owner);
                }
            }
        }
    }
}
