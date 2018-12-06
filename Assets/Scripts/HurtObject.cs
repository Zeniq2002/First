using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HurtObject : MonoBehaviour
{
    //om något nuddar den här och har tagen Player
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Om något med tagen (Player) colliderar gör...
        if(collision.gameObject.tag == "Player")
        {
            //Hämtar scenen som PLayer är på just nu
            Scene active = SceneManager.GetActiveScene();
            SceneManager.LoadScene(active.name);
        }
    }
}
