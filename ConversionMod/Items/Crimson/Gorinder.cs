using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TAPI;
using Terraria;
using Microsoft.Xna.Framework;

namespace ConversionMod
{
    class Gorinder : ModItem
    {
        public Gorinder(ModBase mb, Item I) : base(mb, I) { }
        Dust[] d;

        public override void UseItemEffects(Player P, Rectangle rect)
        {
            foreach (Gore element in Main.gore)
            { 
                if (element.active && (400/*.0d*/ >= Math.Pow((element.position.X - P.position.X), 2) + Math.Pow((element.position.Y - P.position.Y), 2)))
                {
                    Main.PlaySound(23);
                    //----- Primary effect
                    if (Main.rand.Next(1) == 0)
                    {
                        Item.NewItem((int)element.position.X, (int)element.position.Y, Main.goreTexture[element.type].Height, Main.goreTexture[element.type].Width, ItemDef.byName["Terraria:Vertebrae"].type, Main.rand.Next(1, 4));
                    }
                    else
                    {
                        Item.NewItem((int)element.position.X, (int)element.position.Y, Main.goreTexture[element.type].Height, Main.goreTexture[element.type].Width, ItemDef.byName["Terraria:Bone"].type, Main.rand.Next(1, 4));
                    }
                }
                //----- secondary effect vars
                int HealComponent1 = Main.goreTexture[element.type].Width;
                int HealComponent2 = Main.goreTexture[element.type].Height;
                bool dusts0to3despawned = false; //long var name...
                //----- Blood particles wich come to you
                for (int i = 0; i < 4; i++)
                {
                    d[i].type = 23;
                    d[i].position.X = element.position.X;
                    d[i].position.Y = element.position.Y;
                    d[i].velocity.X = P.position.X - element.position.X + (20 - P.position.X);
                    d[i].velocity.Y = P.position.Y - element.position.Y + (20 - P.position.Y);
                    d[i].active = d[i].position == P.position ? true : false;
                    d[i].noGravity = false;
                    //----- Secondary effect
                    if (!d[0].active && !d[1].active && !d[2].active && !d[3].active)
                        dusts0to3despawned = true;
                    if (d[i].position == P.position && dusts0to3despawned)
                        P.statLife += HealComponent1 * HealComponent2 / 16;
                }
            }
        }
    }
}
