using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public abstract class MovementMotor : MonoBehaviour
{
    public float speed = 8;

    abstract public void Move(Vector3 direction);
    abstract public void Rotate(Vector3 direction);
}