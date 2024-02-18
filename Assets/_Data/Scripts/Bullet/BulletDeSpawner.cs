using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDeSpawner : DeSpawnerByDistance
{
    public override void DespawnObject()
    {
        BulletSpawner.Instance.Despawn(transform.parent);
    }
}
