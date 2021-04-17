using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class facingGoal : MonoBehaviour
{
    public Transform other;
    public GameObject particle;

    void Update()
    {
        if (other)
        {
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            Vector3 toOther = other.position - transform.position;

            if (Vector3.Dot(forward, toOther) > 0)
            {
                Instantiate(particle, transform.position, Quaternion.identity);
            }
        }
    }
}
