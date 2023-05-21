using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiltControl : MonoBehaviour
{
    private Touch touch;



    private Vector2 touchPosition;

    private Quaternion rotationX, rotationZ;

    private float tiltSpeedModifier = 0.1f;

    private void Update()
    {
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Moved:

                    rotationX = Quaternion.Euler(-touch.deltaPosition.x * tiltSpeedModifier, 0f, 0f);

                    transform.rotation = rotationX * transform.rotation;

                    rotationZ = Quaternion.Euler(0f, 0f, - touch.deltaPosition.y * tiltSpeedModifier);

                    transform.rotation = transform.rotation * rotationZ;

                    break;
            }
        }
    }
}
