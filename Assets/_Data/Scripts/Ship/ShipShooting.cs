using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShooting : MonoBehaviour
{
    [SerializeField] protected Transform bullet;
    [SerializeField] protected float shootDelay = .2f;

    protected float shootTimer;
    protected bool isShooting;

    private void Update()
    {
        this.IsShooting();
    }

    private void FixedUpdate()
    {
        this.Shooting();
    }

    private bool IsShooting()
    {
        return isShooting = InputManager.Instance.OnFiring == 1;
    }

    private void Shooting()
    {
        shootTimer += Time.fixedDeltaTime;

        if (!this.isShooting && shootTimer < shootDelay) return;

        shootTimer = 0;
        Vector3 spawnPosition = transform.position;
        Quaternion spawnRot = transform.parent.rotation;

        Transform newBullet = Instantiate(bullet, spawnPosition, spawnRot);
        newBullet.gameObject.SetActive(true);
    }
}
