using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class creditHandler : MonoBehaviour
{
    public string toMenu;

    public void goToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(toMenu);
    }
}
