using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXSpawner : Spawner
{
    public static FXSpawner Instance;
    public static string smoke1 = "Explore";
    public static string impact1 = "Impact";

    protected override void Awake()
    {
        base.Awake();

        Instance = this;
    }
}
