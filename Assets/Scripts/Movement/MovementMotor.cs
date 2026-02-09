using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MovementMotor : MonoBehaviour
{
    public float speed = 8;

    private CharacterController characterController;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    public void Move(Vector3 direction)
    {
        characterController.Move(direction * speed * Time.deltaTime);
    }

    public void Rotate(Vector3 direction)
    {
        if (direction.sqrMagnitude < 0.01f) return;

        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 10f * Time.deltaTime);
    }
}