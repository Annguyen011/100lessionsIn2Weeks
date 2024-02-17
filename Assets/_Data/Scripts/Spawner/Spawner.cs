using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public abstract class Spawner : SaiMonoBehaviour
{
    [SerializeField] protected List<Transform> prefabs = new List<Transform>();
    [SerializeField] protected List<Transform> pools = new List<Transform>();
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

    public virtual Transform Spawn(string name, Vector3 pos, Quaternion rot)
    {
        Transform newPrefab = GetPrefabByName(name);

        if (newPrefab == null)
        {
            Debug.LogWarning("Dont find prefab" + name);
            return null;
        }

        Transform prefab = GetObjectFromPool(newPrefab);
        if (prefab == null)
        {
            Debug.LogWarning("Dont find " + prefab);
        }

        prefab.SetPositionAndRotation(pos, rot);
        prefab.parent = holder;

        return prefab;
    }

    protected virtual Transform GetObjectFromPool(Transform prefab)
    {
        foreach (Transform poolObj in this.pools)
        {
            if (poolObj.name == prefab.name)
            {
                this.pools.Remove(poolObj);
                return poolObj;
            }
        }

        Transform newPrefab = Instantiate(prefab);
        newPrefab.name = prefab.name;
        return newPrefab;
    }

    public virtual Transform GetPrefabByName(string name)
    {
        return prefabs.Find(transform => transform.name == name);
    }

    public virtual void DeSpawn(Transform obj)
    {
        pools.Add(obj);
        obj.gameObject.SetActive(false);
    }
}
