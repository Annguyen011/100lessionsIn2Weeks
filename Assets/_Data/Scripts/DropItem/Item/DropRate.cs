using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[Serializable]
public class DropRate
{
    public ItemSO itemSO;
    public int minDrop;
    public int maxDrop;
    [Header("Range")]
    [Range(0, 100)] public float dropRate;
}
