using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hejsan : MonoBehaviour
{
    //Ger ett name till LoadScene (Namnet är scenen som ska loada)
    public string levelToLoad = "NextLevel";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Om något med TAG;Player colliderar så Loadar SampleScene 
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
