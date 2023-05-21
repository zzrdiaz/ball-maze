using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
    public GameObject ball;

    public gameOverHandler GOH;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Sphere")
        {
            Debug.Log("fisinih");
            GOH.youWin();
        }
    }
}
