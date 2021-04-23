using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text highscoretext;
    void Update()
    {
        highscoretext.text = "Highscore:" + PlayerPrefs.GetInt("Highscore");
    }
}
