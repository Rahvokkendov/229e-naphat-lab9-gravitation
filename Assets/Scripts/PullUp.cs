using UnityEngine;

public class PullUp : MonoBehaviour
{
    /* T = mg + ma
         = m(g + a)*/
    public float tension;
    public float mass;
    public float accel;

    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mass = rb.mass;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        tension = mass * (-Physics.gravity.y + accel);
        rb.AddForce(Vector3.up * tension);
    }
}
