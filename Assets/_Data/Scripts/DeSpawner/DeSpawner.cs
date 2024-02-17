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

    protected virtual void DespawnObject()
    {
        Destroy(transform.parent.gameObject);
    }

    protected abstract bool CanDeSpawn();
}
