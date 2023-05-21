using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuHandler : MonoBehaviour
{
    public string game;

    public GameObject settingsPanel, InfoPanel, soundON, soundOFF;

    public bool panelOpened = false, bgmPlay = true;

    public AudioSource bgm;


    public void playGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(game);
    }

    public void openSettings()
    {
        if(panelOpened == false)
        {
            settingsPanel.SetActive(true);
            panelOpened = true;
        }
        else
        {
            settingsPanel.SetActive(false);
            panelOpened = false;
        }
        
        
    }

    public void openInfo()
    {
        if (panelOpened == false)
        {
            InfoPanel.SetActive(true);
            panelOpened = true;
        }
        else
        {
            InfoPanel.SetActive(false);
            panelOpened = false;
        }
        
    }

    public void soundControl()
    {
        if (bgmPlay == true)
        {
            bgm.Stop();
            bgmPlay = false;
            soundOFF.SetActive(true);
            soundON.SetActive(false);
        }
        else
        {
            bgm.Play();
            bgmPlay = true;
            soundOFF.SetActive(false);
            soundON.SetActive(true);
        }
    }

    public void quit()
    {
        Application.Quit();
    }
}
