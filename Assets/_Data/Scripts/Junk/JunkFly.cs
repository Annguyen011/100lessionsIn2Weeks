using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkFly : SaiMonoBehaviour
{
    [SerializeField] private float angle;

    protected override void OnEnable()
    {
        base.OnEnable();

        float randomAngle = Random.Range(-angle, angle);

        Vector2 camPos = Camera.main.transform.position;
        Vector2 parentPos = transform.parent.position;

        camPos.x += randomAngle;
        camPos.y += randomAngle;

        Vector2 diff = camPos - parentPos;
        diff.Normalize();

        float rotZ = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0,0,rotZ);

        Debug.DrawLine(parentPos, parentPos + diff * 7, Color.red);
    }
}
