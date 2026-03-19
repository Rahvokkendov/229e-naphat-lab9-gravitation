using UnityEngine;
using UnityEngine.InputSystem;

public class RayShooter : MonoBehaviour
{
    [SerializeField] private Transform shootPos;
    [SerializeField] private GameObject shootVfxPrefab;
    [SerializeField] private GameObject hitVfxPrefab;
    [SerializeField] private int damage = 10;
    int rayCastDistance = 30;
    
    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        RaycastHit hit;

        Debug.DrawRay(shootPos.position, transform.forward * rayCastDistance, Color.yellowGreen);

        if(Physics.Raycast(shootPos.position, transform.forward, out hit, rayCastDistance))
        {
            Debug.DrawRay(shootPos.position, transform.forward * hit.distance, Color.red);

            //Debug.Log($"Ray Hits: {hit.collider.name}");
            if (Mouse.current.rightButton.wasPressedThisFrame)
            {
              var shootVfx =  Instantiate(shootVfxPrefab, shootPos.position, shootPos.rotation, transform);
              var hitVfx =  Instantiate(hitVfxPrefab, hit.point, Quaternion.identity);

                Destroy(shootVfx,3.5f);
                Destroy(hitVfx, 4f);
                if(hit.collider.CompareTag("Enemy"))
                {
                    Enemy enemy = hit.collider.GetComponent<Enemy>();
                    if(enemy != null)
                    {
                        enemy.TakeDamage(damage);
                    }
                }
            }
        }

    }
}
