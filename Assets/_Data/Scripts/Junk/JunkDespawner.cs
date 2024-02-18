using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkDespawner : DeSpawnerByDistance
{
    public override void DespawnObject()
    {
        JunkSpawner.Instance.Despawn(transform.parent);
    }
}
