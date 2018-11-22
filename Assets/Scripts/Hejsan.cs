using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hejsan : MonoBehaviour
{
    public string levelToLoad = "NextLevel";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //om Player colliderar så printar den Victory Royal och Loadar SampleScene 
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
