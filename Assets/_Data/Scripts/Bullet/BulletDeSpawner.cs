using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDeSpawner : DeSpawnerByDistance
{
    protected override void DespawnObject()
    {
        BulletSpawner.Instance.DeSpawn(transform.parent);
    }
}
