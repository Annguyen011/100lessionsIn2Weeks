using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : SaiMonoBehaviour
{
    public BulletImpact impact;
    public BulletDeSpawner deSpawner;
    public BulletDmgSender sender;
    public Transform model;
    public Transform shooter;

    protected override void LoadComponents()
    {
        base.LoadComponents();

        if (impact == null)
        {
            impact = GetComponentInChildren<BulletImpact>();
        }

        if (sender == null)
        {
            sender = GetComponentInChildren<BulletDmgSender>();
        }

        if (model == null)
        {
            model = transform.Find("Model");
        }

        if (deSpawner == null)
        {
            deSpawner = GetComponentInChildren<BulletDeSpawner>();
        }
    }

    public void SetShooter(Transform shooter)
    {
        this.shooter = shooter;
    }
}
