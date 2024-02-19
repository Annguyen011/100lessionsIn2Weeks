using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class ItemPickupable : SaiMonoBehaviour
{
    [SerializeField] protected SphereCollider _collider;

    public void OnMouseDown()
    {
        PlayerCtrl.Instance.PlayerPickup.ItemPickup(this);
    }

    #region Override
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadTrigger();
    }
    #endregion


    protected virtual void LoadTrigger()
    {
        if (this._collider != null) return;
        this._collider = transform.GetComponent<SphereCollider>();
        this._collider.isTrigger = true;
        this._collider.radius = 1;
        Debug.LogWarning(transform.name + " LoadTrigger", gameObject);
    }
    public ItemCode String2ItemCode(string itemName)
    {
        try
        {

            return (ItemCode)Enum.Parse(typeof(ItemCode), itemName);
        }
        catch (Exception e)
        {
            print(e);
            return ItemCode.None;
        }
    }

    public ItemCode GetItemCode()
    {
        return String2ItemCode(transform.parent.name);
    }

    public void Picked()
    {
        ItemDropSpawner.Instance.Despawn(transform.parent);
    }



}
