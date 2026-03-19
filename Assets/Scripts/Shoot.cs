using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefabs;
    public Transform shooter;
    public float shootForce;


    // Update is called once per frame
    void Update()
    {
        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            Fire();
        }
    }

    void Fire ()
    {
        GameObject bullet = Instantiate(bulletPrefabs, shooter.position, transform.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(shooter.forward * shootForce, ForceMode.Impulse);
        Destroy(bullet, 10);
    }
}
