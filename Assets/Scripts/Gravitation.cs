using NUnit.Framework;
using UnityEngine;

using System.Collections.Generic;
public class Gravitation : MonoBehaviour
{
    public static List<Gravitation> otherObject;
    private Rigidbody rb;
    const float G = 0.006673f;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        if (otherObject == null)
        {
            otherObject = new List<Gravitation>();
        }
        otherObject.Add(this);
    }

    private void FixedUpdate()
    {
        foreach (Gravitation obj in otherObject)
        {
            if (obj != this)
            {
                AttractionForce(obj);
            }
        }
    }

    void AttractionForce(Gravitation other)
    {
        Rigidbody otherRb = other.rb;
        Vector3 direction = rb.position - otherRb.position;
        float distance = direction.magnitude;
        if(distance == 0f) return;

        float forceMagnitude = G * ((rb.mass * otherRb.mass) / Mathf.Pow(distance, 2));
        Vector3 gravitionnalForce = forceMagnitude * direction.normalized;
        otherRb.AddForce(gravitionnalForce);
    }
}
