using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="ItemProfile", menuName ="SO/ItemProfile")]
public class ItemProfileSO : ScriptableObject
{
    public ItemCode itemCode = ItemCode.None;
    public ItemType itemType;
    public string itemName = "None";
    public int defaulMaxStack = 7;
}
