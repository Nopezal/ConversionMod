using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using TAPI;
using Terraria;

namespace ConversionMod
{
    class CremesinialRod : ModItem
    {
        public override void UseItemEffects(Player P, Rectangle rect)
        {
            Projectile.NewProjectile(new Vector2(P.position.X, P.position.Y + 10), Vector2.Zero, "ConversionMod:CremesinialCreature", 0, 0, P.whoAmI);
        }
    }
}
