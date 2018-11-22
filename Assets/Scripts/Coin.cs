using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //ger ett värde till score
    public int score = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //om PLayer colliderar med con destroy Coin
        if (collision.tag == "Player")
        {
            //skapa en temporär variabel "controller" och sätt den till
            //resultatet av sökning efter objektet med taggen "GameController"
            GameObject controller = GameObject.FindWithTag("GameController");
            if (controller != null)
            {
                //Skapa en temporär variabel "tracker" och sätt den till
                //resultatet av sökningen efter komponenten "ScoreTracker"
                ScoreTracker tracker = controller.GetComponent<ScoreTracker>();
                if (tracker != null)
                {
                    tracker.totalScore += score;
                }
                else
                {
                    Debug.LogError("ScoreTracker saknas på GameController");
                }
            }
            else
            {
                Debug.LogError("Gamecontroller finns inte.");
            }

            //Destroys GameObject (Coin)
            Destroy(gameObject);
        }
    }

}
