using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkCtrl : SaiMonoBehaviour
{
    public Transform model;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        if(model == null)
        {
            model = transform.Find("Model");
        }
    }
}
