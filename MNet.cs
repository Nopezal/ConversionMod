using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using TAPI;

namespace ConversionMod
{
    public sealed class MNet : ModNet
    {
        public override void NetReceive(BinBuffer bb, int msg, MessageBuffer buffer)
        {
            base.NetReceive(bb, msg, buffer);
        }
    }
}
