using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShooting : MonoBehaviour
{
    [SerializeField] protected float shootDelay = .2f;

    protected float shootTimer;
    protected bool isShooting;
    private ChangeParentScale changeScale;

    private void Awake()
    {
        changeScale = GetComponent<ChangeParentScale>();
    }

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

        changeScale.StartChange(shootDelay);

        shootTimer = 0;

        Vector3 spawnPosition = transform.position;
        Quaternion spawnRot = transform.parent.rotation;

        Transform newBullet = BulletSpawner.Instance.Spawn(BulletSpawner.BULLET_1,spawnPosition, spawnRot);
        newBullet.gameObject.SetActive(true);

        changeScale.StopChange(shootDelay);
    }


}
