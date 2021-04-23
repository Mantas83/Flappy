using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public GameObject gameStartCanvas;

    public void StartGame()
    {
        Time.timeScale = 1;
        gameStartCanvas.SetActive(false);
        
    }
}
