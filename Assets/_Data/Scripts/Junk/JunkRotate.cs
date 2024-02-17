using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkRotate : JunkAbstract
{
    [SerializeField] private float rotationSpeed = 3f;

    private void FixedUpdate()
    {
        junkCtrl.model.Rotate(Vector3.forward * rotationSpeed * Time.fixedDeltaTime);
    }
}
