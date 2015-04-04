using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using TAPI;
using Terraria;

namespace ConversionMod.Items
{ 
    class CrimsonTendril : ModItem
    {
        public override void DamageNPC(Player owner, NPC npc, int hitDir, ref int damage, ref float knockback, ref bool crit, ref float critMult)
        {
            npc.AddBuff(BuffDef.byName["ConversionMod:Red Plague"], 60, true);
        }
    }
}

