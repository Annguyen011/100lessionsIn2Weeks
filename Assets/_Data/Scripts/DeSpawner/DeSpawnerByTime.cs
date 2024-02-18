using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeSpawnerByTime : DeSpawner
{
    [SerializeField] private float timeForDie = 2f;

    private float timeCount = 0;

    protected override void OnEnable()
    {
        base.OnEnable();

        timeCount = 0;
    }

    public override bool CanDeSpawn()
    {
        timeCount += Time.fixedDeltaTime;

        return timeCount > timeForDie;
    }
}
