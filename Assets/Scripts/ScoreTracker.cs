using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //<- "namespace"
    //using UnityEngine.UI

public class ScoreTracker : MonoBehaviour
{
    //Den lenkar eller referear till en text
    public TextMeshProUGUI scoreText;

    public int totalScore;

    private void Update()
    {
        scoreText.text = string.Format("Score: {0}", totalScore);
    }
}
