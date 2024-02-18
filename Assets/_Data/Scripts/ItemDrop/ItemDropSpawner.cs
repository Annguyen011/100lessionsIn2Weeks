using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDropSpawner : Spawner
{
    public static ItemDropSpawner Instance;

    protected override void Awake()
    {
        Instance = this;

        base.Awake();
    }
}
