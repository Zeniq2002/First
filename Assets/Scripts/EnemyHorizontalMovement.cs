using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    public float movespeed = 2f;
    public bool isleft;

    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        //Hämtar en rigidbody
        rbody = GetComponent<Rigidbody2D>();
        
        Move(false);
    }

    // Update is called once per frame
    void Update()
    {
        //om man trycker på H flip Enemy Rat
        if(Input.GetKeyDown(KeyCode.H))
        {
            Move(true);
        }
    }

    void Move(bool flip)
    {
        if (flip == true)
        {
            isleft = !isleft;
        }

        if (isleft == true)
        {
            //Om isleft är true set hastigheten till 
            rbody.velocity = new Vector2(-movespeed, rbody.velocity.y);
            //Ger en scala på 1, 1, 1,
            transform.localScale = new Vector3(1, 1, 1);
        }

        else
        {
            rbody.velocity = new Vector2(movespeed, rbody.velocity.y);
            //ger en scala på -1, 1, 1,
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Om den colliderar med Tag; Invisiblewall, flip Rat
        if(collision.tag == "InvisibleWall")
        {
            Move(true);
        }
    }
}
