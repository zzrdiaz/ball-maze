using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballOff : MonoBehaviour
{
    public float time;

    public bool onMaze = true;

    public gameOverHandler GOH;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("border"))
        {
            onMaze = false;
        }
    }

    private void Update()
    {
        if (onMaze == false)
        {
            time -= Time.deltaTime;
        }
        if (time < 0)
        {
           gameOver();
        }
    }

    

    void gameOver()
    {
        Debug.Log("bolanya keluar");
        GOH.ballIsOff();
    }
}
