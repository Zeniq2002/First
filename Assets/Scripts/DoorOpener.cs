using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public int keyGet;
    //triger if a sprite enters the collider
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Specifically only triggers if the player collides on the key
        if (collision.gameObject.tag == "Player")
        {
            //adds a value
            keyGet++;
            //destroys the sprite
            Destroy(gameObject);
        }
    }
}
