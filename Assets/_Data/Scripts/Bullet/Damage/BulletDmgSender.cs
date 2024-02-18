using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDmgSender : DamageSender
{
    [SerializeField] private BulletController controller;

    protected override void LoadComponents()
    {
        base.LoadComponents();

        if(controller == null )
        {
            controller = transform.parent.GetComponent<BulletController>();
        }
    }

    public override void Send(DamagerReceiver damageReceiver)
    {
        base.Send(damageReceiver);

        base.DestroyObj();
    }

    public override void DestroyObj()
    {
        controller.deSpawner.DespawnObject();
    }
}
