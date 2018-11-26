using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartTheGame : MonoBehaviour
{
    //scene att loada är Level1
    public string levelToLoad = "Level1";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Om något med ragen Player rör objeckt med scriptet, Load scene (Level to load) (Level1)
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
