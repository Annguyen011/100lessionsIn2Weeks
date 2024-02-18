using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float speed;

    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, speed);
    }
}
