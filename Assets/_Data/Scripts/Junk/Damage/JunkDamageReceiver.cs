using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkDamageReceiver : DamagerReceiver
{
    private JunkCtrl junkCtrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();

        if(junkCtrl == null)
        {
            junkCtrl = transform.parent.GetComponent<JunkCtrl>();
        }
    }

    protected override void OnDead()
    {
        junkCtrl.despawner.DespawnObject();
    }
}
