using UnityEngine;

public class InputHandler : MonoBehaviour
{
    void Update()
    {
        //Debug.Log(GetTouchDeltaPosition() + " Delta Pos");
        //Debug.Log(IsThereTouchOnScreen() + " touch on screen");
    }

    public Vector2 GetTouchDeltaPosition()
    {
        if(Input.touchCount>0)
        {
            return Input.GetTouch(0).deltaPosition;
        }
        return Vector2.zero;
    }

    public bool IsThereTouchOnScreen()
    {
        if(Input.touchCount>0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
