using UnityEngine;

public class PlayerMovementMotor : MovementMotor
{
    private CharacterController characterController;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    override public void Move(Vector3 direction)
    {
        characterController.Move(direction * speed * Time.deltaTime);
    }

    override public void Rotate(Vector3 direction)
    {
        if (direction.sqrMagnitude < 0.01f) return;

        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 10f * Time.deltaTime);
    }
}
