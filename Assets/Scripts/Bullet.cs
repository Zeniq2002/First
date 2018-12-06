using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 40;
    // Use this for initialization
    void Start()
    {
        //Ger en fart till bullet
        rb.velocity = transform.right * speed;
    }
    //Om bullet colliderar destroy bullet och om den colliderar med enemy gör damage och destroy bullet
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        EnemyTakeDamage enemy = hitInfo.GetComponent<EnemyTakeDamage>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
