using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeSpawnerByDistance : DeSpawner
{
    [SerializeField] protected float distance;

    protected override bool CanDeSpawn()
    {
        return Vector2.Distance(transform.parent.position, Camera.main.transform.position) > distance;
    }
}
