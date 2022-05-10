using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchScript : MonoBehaviour
{
    float startDistance,signMove;
    Vector2 startPos;

    void Update()
    {
        RightSwipe();
        ZoomOn();
    }

    private void RightSwipe()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                startPos = touch.position;
            }
            if (touch.phase == TouchPhase.Moved && Mathf.Sign(touch.deltaPosition.x) != signMove)
            {
                signMove = Mathf.Sign(touch.deltaPosition.x);
                startPos = touch.position;
            }
            if (touch.phase == TouchPhase.Ended)
            {
                if (touch.position.x - startPos.x > 99 && Mathf.Abs(touch.position.y - startPos.y) < 51)
                {
                    Debug.Log("Свайп вправо!");
                }
            }
        }
    }
    private void ZoomOn()
    {
        if (Input.touchCount==2)
        {
            Touch[] touch = Input.touches;

            if(touch[0].phase == TouchPhase.Began || touch[1].phase == TouchPhase.Began)
            {
                startDistance = Vector2.Distance(touch[0].position, touch[1].position);
            }
            if (touch[0].phase == TouchPhase.Ended || touch[1].phase == TouchPhase.Ended)
            {
                if (Vector2.Distance(touch[0].position, touch[1].position) - (startDistance * 1.1f) > 0)
                {
                    if (Mathf.Sign(touch[0].deltaPosition.x) != Mathf.Sign(touch[1].deltaPosition.x) && Mathf.Sign(touch[0].deltaPosition.y) != Mathf.Sign(touch[1].deltaPosition.y))
                    {
                        Debug.Log("Жест увеличения!");
                    }
                }
            }
        }
    }
}
