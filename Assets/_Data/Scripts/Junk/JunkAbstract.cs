using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class JunkAbstract : SaiMonoBehaviour
{
    public JunkCtrl junkCtrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();

        if (junkCtrl == null)
        {
            junkCtrl = transform.parent.GetComponent<JunkCtrl>();
        }
    }
}
