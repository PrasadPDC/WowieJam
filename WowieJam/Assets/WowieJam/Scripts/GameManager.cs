using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject restartPanel;
    [HideInInspector]public bool gameover;
    public float RestartDelay = 1f;

    private void Start()
    {
        gameover = false;
        Time.timeScale = 1f;
        restartPanel.SetActive(false);
    }
    private void Update()
    {
        if(gameover == true)
        {
            restartPanel.SetActive(true);
        }
    }
    public void EndGame()
    {
        // Change this to Go to Main Menu or somewhere
        Invoke("Restart", RestartDelay);

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 0f;
    }
}
