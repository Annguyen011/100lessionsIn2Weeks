using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkDamageReceiver : DamagerReceiver
{


    protected override void OnDead()
    {
        print("Dead");
    }
}
