using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawnerCtrl : SaiMonoBehaviour
{
    protected JunkSpawnerRandom JunkSpawnerRandom;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        if(JunkSpawnerRandom == null)
        {
            JunkSpawnerRandom = GetComponent<JunkSpawnerRandom>();
        }
    }
}
