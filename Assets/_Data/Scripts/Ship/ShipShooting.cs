using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShooting : MonoBehaviour
{
    [SerializeField] protected Transform bullet;

    protected bool isShooting;

    private void FixedUpdate()
    {
        this.Shooting();
    }

    private void Shooting()
    {
        if (!this.isShooting) return;
        
        Instantiate(bullet);
    }
}
