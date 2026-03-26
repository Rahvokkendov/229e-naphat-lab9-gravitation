using UnityEngine;
using UnityEngine.InputSystem;
public class AngularVelocityControl : MonoBehaviour
{
    public float angularSpeed = 1f;
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Keyboard.current.aKey.isPressed)
        {
            rb.angularVelocity = new Vector3(0, angularSpeed, 0);
        }
    }
}
