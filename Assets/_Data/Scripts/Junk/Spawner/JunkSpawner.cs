using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawner : Spawner
{
    public static JunkSpawner Instance;
    public static string Junk_1 = "Asteroids_1";
    public static string Junk_2 = "Asteroids_2";

    protected override void Awake()
    {
        base.Awake();

        Instance = this;
    }

}
