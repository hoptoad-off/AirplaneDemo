using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InteractionController : MonoBehaviour
{
    public event Action Interact;

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.started)
            Interact?.Invoke();
    }
}