using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDespawn : DeSpawnerByDistance
{
    public override void DespawnObject()
    {
        ItemDropSpawner.Instance.Despawn(transform.parent);
    }
}
