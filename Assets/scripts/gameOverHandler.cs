using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverHandler : MonoBehaviour
{
    public GameObject win, timeOut, ballOff;

    public string toMenu, credit;

    

    public void youWin()
    {
        
        win.SetActive(true);
        Time.timeScale = 0;
    }

    public void timeIsOut()
    {
        
        timeOut.SetActive(true);
        
    }

    public void ballIsOff()
    {
        
        ballOff.SetActive(true);
        
    }

    public void Retry()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

    public void backToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(toMenu);
        
    }

    public void toCredit()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(credit);
    }
}
