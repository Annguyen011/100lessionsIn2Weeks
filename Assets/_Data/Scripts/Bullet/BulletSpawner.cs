using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : Spawner
{
    public static BulletSpawner Instance;

    public static string BULLET_1 = "Bullet_1";

    protected override void Awake()
    {
        base.Awake();

        Instance = this;
    }
}
