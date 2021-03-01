using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject restartPanel;
    public GameObject WinePanel;
    [HideInInspector]public bool gameover;
    public float RestartDelay = 1f;
    private AudioManager audios;
    private PlayerController player;
    private void Start()
    {
        audios = GameObject.FindObjectOfType<AudioManager>();
        player = GameObject.FindObjectOfType<PlayerController>();
        audios.Play("InGameSound");
        gameover = false;
        restartPanel.SetActive(false);
        WinePanel.SetActive(false);

    }
    private void Update()
    {
        if(gameover == true)
        {
            restartPanel.SetActive(true);
            Time.timeScale = 0f;
        }
        if(player.isrun == false)
        {
           
            WinePanel.SetActive(true);
            restartPanel.SetActive(false);
        }
    }
    public void EndGame()
    {
       
        // Change this to Go to Main Menu or somewhere
        Restart();
        Time.timeScale = 1f;
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
