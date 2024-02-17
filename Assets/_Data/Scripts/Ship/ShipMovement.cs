using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    [SerializeField] protected float speed = 1f;

    private Vector3 targetPos;

    private void FixedUpdate()
    {
        GetTargetPosition();
        LookAtTarget();
        Movement();
    }

    private void LookAtTarget()
    {
        Vector3 diff = targetPos - transform.position;
        diff.Normalize();

        float rotZ = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0, 0, rotZ);
    }

    private void GetTargetPosition()
    {
        this.targetPos = InputManager.Instance.MouseWorldPos;
        this.targetPos.z = 0f;
    }

    private void Movement()
    {
        Vector3 newPosition = Vector3.Lerp(this.transform.position,
                    this.targetPos, this.speed * Time.deltaTime);
        transform.parent.position = newPosition;
    }
}
