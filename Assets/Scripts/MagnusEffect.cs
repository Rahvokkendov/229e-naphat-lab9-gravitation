using UnityEngine;
using UnityEngine.InputSystem;

public class MagnusEffect : MonoBehaviour
{
    public Vector3 kickPower;
    public float spinAmount = 1.0f;
    public float magnusMultipiler = 0.5f;
    private Rigidbody rb;
    private bool isShoot = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.spaceKey.wasPressedThisFrame && !isShoot)
        {
            rb.AddRelativeForce(kickPower, ForceMode.Impulse);
            rb.AddTorque(Vector3.up * spinAmount);
            isShoot = true;
        }
    }

    private void FixedUpdate()
    {
        if (!isShoot) return;
        Vector3 velocity = rb.linearVelocity;
        Vector3 spin = rb.angularVelocity;
        Vector3 magnusForce = Vector3.Cross(spin, velocity);
        magnusForce *= magnusMultipiler;
        rb.AddForce(magnusForce);

    }
}
