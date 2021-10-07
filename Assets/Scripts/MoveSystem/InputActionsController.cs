using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;


[Serializable]
public class MoveInputEvent : UnityEvent<float, float> { }
[Serializable]
public class InteractionInputEvent : UnityEvent { }
public class InputActionsController : MonoBehaviour
{
    InputActions inputs;
    public MoveInputEvent moveInputEvent;
    public InteractionInputEvent interactionInputEvent;

    private void Awake() { inputs = new InputActions(); }

    private void OnEnable()
    {
        inputs.Movement.Enable();
        inputs.Movement.HorizontalMove.performed += OnMovePerformed;
        inputs.Interaction.Enable();
        inputs.Interaction.Use.performed += OnInteractionPerformed;
    }

    private void OnMovePerformed(InputAction.CallbackContext context)
    {
        Vector2 moveInput = context.ReadValue<Vector2>();
        moveInputEvent.Invoke(moveInput.x, moveInput.y);
    }

    private void OnInteractionPerformed(InputAction.CallbackContext context)
    {
        interactionInputEvent.Invoke();
    }
}
