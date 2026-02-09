using UnityEngine;

[RequireComponent(typeof(MovementController))]
[RequireComponent(typeof(MovementMotor))]
public class MovementBrain : MonoBehaviour
{
    public MovementController controller;
    public MovementMotor motor;

    public Transform cameraTransform;

    private void Awake()
    {
        controller = GetComponent<MovementController>();
        motor = GetComponent<MovementMotor>();

        cameraTransform = Camera.main.transform;
    }

    private void Update()
    {
        Vector3 camForward = cameraTransform.forward;
        Vector3 camRight = cameraTransform.right;

        camForward.y = 0; camRight.y = 0;
        camForward.Normalize();
        camRight.Normalize();

        Vector3 direction = camForward * controller.inputDir.y + camRight * controller.inputDir.x;

        motor.Move(direction);
        motor.Rotate(direction);
    }
}
