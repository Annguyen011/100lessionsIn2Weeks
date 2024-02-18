using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawnerRandom : SaiMonoBehaviour
{
    [SerializeField] private float timerDelay = 2f;

    private JunkSpawnerCtrl junkSpawnerCtrl;

    private float timer;

    protected override void Start()
    {
        base.Start();
    }

    private void FixedUpdate()
    {
        JunkSpawning();
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadJunkSpawner();
    }

    private void LoadJunkSpawner()
    {
        if (junkSpawnerCtrl == null)
        {
            junkSpawnerCtrl = GetComponent<JunkSpawnerCtrl>();
        }
    }

    private void JunkSpawning()
    {
        timer += Time.fixedDeltaTime;
        if (timer < timerDelay) return;

        timer = 0;

        Transform ranPos = junkSpawnerCtrl.JunkSpawnPoints.GetRandom();
        Transform junk = JunkSpawner.Instance.Spawn(JunkSpawner.Instance.RandomPrefab(), ranPos.position, transform.rotation);
        junk.gameObject.SetActive(true);
    }
}
