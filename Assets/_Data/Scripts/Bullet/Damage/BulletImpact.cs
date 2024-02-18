using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SphereCollider))]
[RequireComponent(typeof(Rigidbody))]
public class BulletImpact : BulletAbstract
{
    [SerializeField] private float radius = .6f;

    protected SphereCollider sphereCollider;
    protected Rigidbody rb;

    protected override void LoadComponents()
    {
        base.LoadComponents();

        LoadCollider();
        LoadRigidbody();
    }

    private void LoadRigidbody()
    {
        if (rb != null) return;

        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    private void LoadCollider()
    {
        if (sphereCollider != null) return;

        sphereCollider = GetComponent<SphereCollider>();
        sphereCollider.isTrigger = true;
        sphereCollider.radius = radius;
    }

    private void CreateImpactFX(Collider other)
    {
        string fxName = GetImpactName();

        Transform fx = FXSpawner.Instance.Spawn(fxName, transform.position, transform.rotation);
        fx.gameObject.SetActive(true);
    }

    private string GetImpactName()
    {
        return FXSpawner.impact1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.parent.name == controller.shooter.name) return;

        controller.sender.Send(other.transform);
        CreateImpactFX(other);
    }


}
