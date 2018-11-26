using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    //En variabel som är ett heltal
    public int touches;
   
    //när trigger rör något då ökar touches
    private void OnTriggerEnter2D(Collider2D collision)
    {
        touches++;
    }
    //när trigger rör inget do sänks touches
    private void OnTriggerExit2D(Collider2D collision)
    {
        touches--;
    }
}
