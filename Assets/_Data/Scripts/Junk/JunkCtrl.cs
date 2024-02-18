using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkCtrl : SaiMonoBehaviour
{
    public Transform model;
    public JunkSO junkSO;
    public JunkDespawner despawner;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        if(model == null)
        {
            model = transform.Find("Model");
        }

        if(despawner == null)
        {
            despawner = GetComponentInChildren<JunkDespawner>();
        }

        if(junkSO == null)
        {
            string path = "Junk/" + transform.name;
            junkSO = Resources.Load<JunkSO>(path);
        }
    }
}
