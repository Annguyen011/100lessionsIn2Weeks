using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXSpawner : Spawner
{
    public static FXSpawner Instance;

    protected override void Awake()
    {
        base.Awake();

        Instance = this;
    }
}
