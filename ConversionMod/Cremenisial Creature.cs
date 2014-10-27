using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using TAPI;
using Terraria;

namespace ConversionMod
{
    class CremenisialCreature : ModProjectile
    {
        public CremenisialCreature(ModBase mb, Projectile P) : base(mb, P) { }

        Player owner = Main.localPlayer;


        public override void AI()
        {
            Projectile P = this.projectile;
            float timer = 240;

            foreach (NPC element in Main.npc)
            {
                Vector2 oldVel = element.velocity;
                for (int i = 0; i < timer; i++)
                {
                    if(i == timer)
                        Projectile.NewProjectile(P.position, oldVel, "ConversionMod:SpikeballOfFlesh", 76, 1, owner.whoAmI);
                }
            }
        }
    }
}