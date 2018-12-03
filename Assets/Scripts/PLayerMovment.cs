using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//atribut, påverkar det som är under. sägger att en sack måste ha något för att fungera
[RequireComponent(typeof(Rigidbody2D))]
public class PLayerMovment : MonoBehaviour
{
    //gör så att det under bara kan ha en range mellan 0 och 20
    [Range(0, 20f)]

    //En floot för hur högt vi kan Movespeed och Jumheight
    public float movespeed;
    public float jumpheight;
    //Ger en groundcheck
    public GroundCheck groundCheck;
    public float dashForce = 300f;
    //Den refererar till en rigidbody i scenen
    private Rigidbody2D rbody;

    public Rigidbody2D myRigidbody;
    //Use this for initialization
    void Start()
    {
        //Den hittar en komponent och länkar den till 
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Hastighet är likamed 
        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * movespeed, rbody.velocity.y);
        if(rbody.velocity.x < 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if(rbody.velocity.x > 0)
        {
            transform.localScale = new Vector3(- 1, 1, 1);
        }
        //om man tryker ner space och...
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Om variabeln groundcheck.touches = 0. gör...
            if (groundCheck.touches > 0)
            {
                //Hastigheten ändras på x led men inte y led
                rbody.velocity = new Vector2(rbody.velocity.x, jumpheight);

            }
        }

    }
}
