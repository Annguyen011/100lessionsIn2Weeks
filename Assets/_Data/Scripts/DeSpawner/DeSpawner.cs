using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DeSpawner : SaiMonoBehaviour
{
    private void FixedUpdate()
    {
        DeSpawning();
    }

    protected virtual void DeSpawning()
    {
        if(!CanDeSpawn()) return;
        DespawnObject();
    }

    public virtual void DespawnObject()
    {
        Destroy(transform.parent.gameObject);
    }

    public abstract bool CanDeSpawn();
}
