using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseHandler : MonoBehaviour
{
    public GameObject pausePanel;

    public string mainMenu;

    public bool isPaused = false;

    public AudioSource bgm;

    public void gamePauseAndResume()
    {
        if (isPaused == false)
        {
            Time.timeScale = 0;
            pausePanel.SetActive(true);
            
            isPaused = true;
            bgm.Pause();
        }
        else
        {
            Time.timeScale = 1;
            pausePanel.SetActive(false);
            
            isPaused = false;
            bgm.Play();
        }
    }

    public void restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void backToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(mainMenu);
    }
}
