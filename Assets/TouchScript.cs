using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchScript : MonoBehaviour
{
    Vector2 startPos;

    void Update()
    {
        RightSwipe();
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
            Vector2[] startPoses = new Vector2[2];
            float startDistance = 0;

            if(touch[0].phase == TouchPhase.Began || touch[1].phase == TouchPhase.Began)
            {
                startDistance = Vector2.Distance(touch[0].position, touch[1].position);
                for (int i = 0; i < touch.Length; i++)
                {
                    startPoses[i] = touch[i].position;
                }
            }
            if (touch[0].phase == TouchPhase.Ended || touch[1].phase == TouchPhase.Ended)
            {
                if (Vector2.Distance(touch[0].position, touch[1].position) - startDistance > 0)
                {
                    Debug.Log("Жест увеличения!");
                }
            }
        }
    }
}
