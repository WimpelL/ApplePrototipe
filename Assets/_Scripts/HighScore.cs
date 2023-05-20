using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class HighScore : MonoBehaviour
{
    
    static public int score = 1000;

    void Awake() {
        {
            if(PlayerPrefs.HasKey("HighScore"))
            {
                score = PlayerPrefs.GetInt("HighScore");
            }
            PlayerPrefs.SetInt ("HighScore", score);
        }
    }
    
    void Update()
    {
        TextMeshPro gt = this.GetComponent<TextMeshPro>();
        gt.text = "High Score: " +score;
        if(score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt( "HighScore", score);
        }

    }
}
