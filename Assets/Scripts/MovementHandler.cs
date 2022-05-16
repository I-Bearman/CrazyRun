using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    [SerializeField] private float ballSpeed;
    public InputHandler inputHandler;

    void Start()
    {
        if (inputHandler == null)
        {
            Debug.LogError("InputHandler не назначен");
        }
    }

    void Update()
    {
        MoveBall();
    }

    private void MoveBall()
    {
        Vector2 currentDeltaPos = inputHandler.GetTouchDeltaPosition();
        currentDeltaPos *= ballSpeed;
        Vector3 newGravityVector = new Vector3(currentDeltaPos.x, Physics.gravity.y, currentDeltaPos.y);
        Physics.gravity = newGravityVector;
    }
}
