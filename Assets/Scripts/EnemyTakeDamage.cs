using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTakeDamage : MonoBehaviour
{

    public int health = 100;

    //Om health blir 0 eller mindre än 0 gör (Die)
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }
    //Om den gör die Destroy game object
    void Die()
    {
        Destroy(gameObject);
    }
}
