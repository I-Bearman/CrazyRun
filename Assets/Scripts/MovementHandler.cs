using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    [SerializeField] private Rigidbody field;
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
        //FieldTorque();
    }

    private void MoveBall()
    {
        Vector2 currentDeltaPos = inputHandler.GetTouchDeltaPosition();
        currentDeltaPos *= ballSpeed;
        Vector3 newGravityVector = new Vector3(currentDeltaPos.x, Physics.gravity.y, currentDeltaPos.y);
        Physics.gravity = newGravityVector;
    }

    private void FieldTorque()
    {
        Vector2 currentDeltaPos = inputHandler.GetTouchDeltaPosition();
        currentDeltaPos *= ballSpeed;
        Vector3 newTorqueVector = new Vector3(currentDeltaPos.y, 0, -currentDeltaPos.x);
        field.AddTorque(newTorqueVector);
    }
}
