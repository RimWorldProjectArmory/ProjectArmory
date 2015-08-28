using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Verse;
using Verse.Sound;
using RimWorld;


namespace ProjectArmory
{
    class PA_Bullet : Bullet
    {

        protected override void Impact(Thing hitThing)
        {
            base.Impact(hitThing);
            if (hitThing != null)
            {
                int damageAmountBase = this.def.projectile.damageAmountBase;
                BodyPartDamageInfo value = new BodyPartDamageInfo(null, null);
                DamageInfo dinfo = new DamageInfo(this.def.projectile.damageDef, damageAmountBase, this.launcher, this.ExactRotation.eulerAngles.y, new BodyPartDamageInfo?(value), this.equipment);
                hitThing.TakeDamage(dinfo);
                ExplosionThing(hitThing.Position);//Explosion method luncher
            }
            else
            {
                SoundDefOf.BulletImpactGround.PlayOneShot(base.Position);
                MoteThrower.ThrowStatic(this.ExactPosition, ThingDefOf.Mote_ShotHit_Dirt, 1f);
                ExplosionThing(this.Position);//Explosion method luncher
            }

        }

        private void ExplosionThing(IntVec3 position) //Explosion method
        {
            BodyPartDamageInfo value1 = new BodyPartDamageInfo(null, new BodyPartDepth?(BodyPartDepth.Outside)); //What body parts will be damaged, you can use Inside, Outside and Inherit(no ide what this means and do) 
            ExplosionInfo explosionInfo = new ExplosionInfo(); //This create new explosion instance 
            explosionInfo.center = position; // Center of explosion, if hitThing exist it will use hitThing position, if not then it will use bullet position
            explosionInfo.radius = UnityEngine.Random.Range(1f, 5f); // This is randome range from 1 to 5 but you can set any you want. "Exeample: explosionInfo.radius =5f" this is 5 square radius
            explosionInfo.dinfo = new DamageInfo(this.def.projectile.damageDef, this.def.projectile.damageAmountBase, this.launcher, new BodyPartDamageInfo?(value1), null);// This packs all our explosion info stuff above into dinfo so explosion class can use it(i think :D)
            explosionInfo.DoExplosion(); // This starts explosion class with our info pack to do BOOM!

        }
    }
}