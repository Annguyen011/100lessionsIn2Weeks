using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner : SaiMonoBehaviour
{
    [SerializeField] protected List<Transform> prefabs = new List<Transform>();
    [SerializeField] protected Transform holder;

    protected override void Reset()
    {
        base.Reset();
    }

    protected override void Awake()
    {
        base.Awake();
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();

        holder = transform.GetChild(1);
        LoadPrefab();
    }

    private void LoadPrefab()
    {
        if (prefabs.Count > 0) return;

        foreach (Transform prefab in transform.GetChild(0)) 
        {
            prefabs.Add(prefab);
            prefab.gameObject.SetActive(false);
        }
    }

    public virtual Transform Spawn(Vector3 pos, Quaternion rot)
    {
        Transform newPrefab = prefabs[0];
        Transform prefab = Instantiate(newPrefab, pos, rot);

        return prefab;
    }
}
