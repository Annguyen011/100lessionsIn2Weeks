using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : SaiMonoBehaviour
{
    [SerializeField] protected List<Transform> points = new List<Transform>();

    protected override void LoadComponents()
    {
        base.LoadComponents();

        foreach(Transform t in transform)
        {
            points.Add(t);
        }
    }

    public virtual Transform GetRandom()
    {
        return points[UnityEngine.Random.Range(0, points.Count)];
    }
}
