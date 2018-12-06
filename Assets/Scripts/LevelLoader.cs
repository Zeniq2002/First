using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    //Ger ett name till LoadScene (Namnet är scenen som ska loada)
    public string levelToLoad = "Level1";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Om något med TAG;Player colliderar Gör LoadScene(LevelToLoad) 
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
