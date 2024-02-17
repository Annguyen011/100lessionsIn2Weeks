using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeParentScale : MonoBehaviour
{
    [SerializeField] protected float changeScale = .6f;

    protected Vector3 startLocaScale;

    private void Start()
    {
        startLocaScale = transform.parent.localScale;
    }

    public void StartChange(float delay)
    {
        StartCoroutine(ChangeScale(delay));
    }
    
    public void StopChange(float delay)
    {
        StopCoroutine(ChangeScale(delay));
    }

    private IEnumerator ChangeScale(float delay)
    {
        transform.parent.localScale = Vector3.one * changeScale;

        yield return new WaitForSeconds(delay);

        transform.parent.localScale = startLocaScale;
    }
}
