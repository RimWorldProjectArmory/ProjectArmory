using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Verse;

namespace ProjectArmory
{
    internal class PABulletDef : ThingDef
    {
        public bool secondaryExplode = false;
        public DamageDef secondaryDamageType;
        public int secondaryDamage = 0;
        public float secondaryRadius = 0;
    }
}