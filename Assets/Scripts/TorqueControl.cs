using UnityEngine;
using UnityEngine.InputSystem;
public class TorqueControl : MonoBehaviour
{
    public float torquePower = 1f;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Keyboard.current.dKey.isPressed)
        {
            rb.AddRelativeTorque(Vector3.up * torquePower);
        }
    }
}
