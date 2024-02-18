using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BulletAbstract : SaiMonoBehaviour
{
    [SerializeField] protected BulletController controller;

    protected override void LoadComponents()
    {
        base.LoadComponents();

        if (controller == null)
        {
            controller = transform.parent.GetComponent<BulletController>();
        }
    }
}
