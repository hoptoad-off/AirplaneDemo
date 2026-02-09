using System;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class MovementController : MonoBehaviour
{
    [NonSerialized] public Vector2 inputDir;

    public void OnMove(CallbackContext context)
    {
        inputDir =  context.ReadValue<Vector2>();
    }
}
