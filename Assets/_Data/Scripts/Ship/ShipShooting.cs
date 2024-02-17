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
        this.IsShooting();
    }

    private bool IsShooting()
    {
        return isShooting = InputManager.Instance.OnFiring == 1;
    }

    private void Shooting()
    {
        if (!this.isShooting) return;
        Vector3 spawnPosition = transform.position;
        Quaternion spawnRot = transform.parent.rotation;

        Instantiate(bullet, spawnPosition, spawnRot);
    }
}
