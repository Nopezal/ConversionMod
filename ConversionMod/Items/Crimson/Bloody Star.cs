using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TAPI;
using Terraria;
using Microsoft.Xna.Framework;

namespace ConversionMod
{
    class BloodyStar : ModItem
    {
        int speedUp = 0;

        public override void UseItemEffects(Player P, Rectangle rect)
        {
            for (int i = 0; i < 5; i++)
            {
                speedUp += 5;
                Gore gore = new Gore();
                gore.type = Main.rand.Next(1, GoreDef.gores.Count);
                gore.position = new Vector2(P.position.X + Main.rand.Next(-50, 50), P.position.Y + 200);
                gore.velocity = new Vector2(0, speedUp);
                gore.active = true;
                Projectile.NewProjectile(gore.position, gore.velocity, "ConversionMod:BloodyStar", 67, 0, P.whoAmI);
            }
        }
    }
}
