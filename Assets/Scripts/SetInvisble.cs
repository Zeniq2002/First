using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInvisble : MonoBehaviour
{

    //Use this for initialization
    void Start()
    {
        //Hämta en komponent och steng av den, den blir osynlig
        GetComponent<SpriteRenderer>().enabled = false;

    }

}
