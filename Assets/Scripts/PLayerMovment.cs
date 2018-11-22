using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PLayerMovment : MonoBehaviour
{
    [Range(0, 20f)]
    //Movespeed och Jumheight
    public float movespeed;
    public float jumpheight;
    //Ger en groundcheck
    public GroundCheck groundCheck;

    private Rigidbody2D rbody;
    
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * movespeed, rbody.velocity.y);
        //om GroundChek<c
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (groundCheck.touches > 0)
            {
            rbody.velocity = new Vector2(rbody.velocity.x, jumpheight);

            }
        }
    }


}
