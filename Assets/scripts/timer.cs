using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    
    [SerializeField] private Text uiText;

    public int duration;

    private int remainingDuration;

    private bool pause;

    public gameOverHandler GOH;

    public GameObject panelTimer;

    private void Start()
    {
        Being(duration);
    }

    private void Being(int second)
    {
        remainingDuration = second;
        StartCoroutine(UpdateTimer());
    }

    private IEnumerator UpdateTimer()
    {
        if (!pause)
        {
            while (remainingDuration >= 0)
            {
                uiText.text = $"{remainingDuration / 60:00} : {remainingDuration % 60:00}";

                remainingDuration--;
                yield return new WaitForSeconds(1F);
            }
            yield return null;
        }
        
        
        OnEnd();
    }

    private void OnEnd()
    {
        //end time, if want do something
        GOH.timeIsOut();
        panelTimer.SetActive(false);
    }
}
