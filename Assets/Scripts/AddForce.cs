using UnityEngine;

public class AddForce : MonoBehaviour
{
    [SerializeField] private float force;
    [SerializeField] private float mass;
    [SerializeField] private float accel;

    void CalculateForce()
    {
        mass = GetComponent<Rigidbody>().mass;
        force = mass * accel;
        GetComponent<Rigidbody>().AddForce(0, force,force);
    }

    public void SetAccelt250()
    {
        accel = 250f;
        CalculateForce();
    }

    public void SetAccelt300()
    {
        accel = 300f;
        CalculateForce();
    }

    public void SetAccelt350()
    {
        accel = 350f;
        CalculateForce();
    }

}
