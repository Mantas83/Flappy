using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;

    private void Start()
    {
        gameOverCanvas.SetActive(false);
        Time.timeScale = 0;
    }

    public void GameOver()
    {
        if (ScoreCounter.score > PlayerPrefs.GetInt("Highscore"))
            PlayerPrefs.SetInt("Highscore", ScoreCounter.score);
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }

}
