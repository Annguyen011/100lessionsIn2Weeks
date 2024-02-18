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

    public void Drop(List<DropRate> dropList, Vector3 pos, Quaternion rot)
    {
        ItemCode itemCode = dropList[0].itemSO.itemCode;
        Transform itemDrop = Spawn(itemCode.ToString(), pos, rot);
        itemDrop.gameObject.SetActive(true);
    }
}
