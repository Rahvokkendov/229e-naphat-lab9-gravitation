using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int health = 50;
    [SerializeField] private GameObject deadVfxPrefab;
    public void TakeDamage(int damage)
    {
        health -= damage;
        print($"{name} took {damage} damage!");
        if ( health <= 0 )
        {
            var deadVfx = Instantiate(deadVfxPrefab, this.transform.position , Quaternion.identity, transform);

            Destroy(deadVfx, 3.5f);
            Destroy(gameObject, 1f);
            
        }
    }
}
