using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawnerCtrl : SaiMonoBehaviour
{
    protected JunkSpawnerRandom JunkSpawnerRandom;
    public JunkSpawnPoints JunkSpawnPoints;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        if(JunkSpawnerRandom == null)
        {
            JunkSpawnerRandom = GetComponent<JunkSpawnerRandom>();
        }

        if(JunkSpawnPoints == null)
        {
            JunkSpawnPoints = GetComponentInChildren<JunkSpawnPoints>();
        }
    }
}
