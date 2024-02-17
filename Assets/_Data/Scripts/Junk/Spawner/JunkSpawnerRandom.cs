using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawnerRandom : SaiMonoBehaviour
{
    [SerializeField] private JunkSpawnerCtrl junkSpawnerCtrl;


    protected override void Start()
    {
        base.Start();
        JunkSpawning();
    }

    private void FixedUpdate()
    {
        //JunkSpawning();
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
        Transform ranPos = junkSpawnerCtrl.JunkSpawnPoints.GetRandom();
        Transform junk = JunkSpawner.Instance.Spawn(JunkSpawner.Junk_1, ranPos.position, transform.rotation);
        junk.gameObject.SetActive(true);
        Invoke(nameof(JunkSpawning), 1f);
    }
}
