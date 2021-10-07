// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""74f1a9bb-d58b-4b66-9f50-939a074ebe94"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMove"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4153660e-60d3-4d67-be35-b4539ea51be2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WSAD"",
                    ""id"": ""42d6d640-d22c-43e6-8d82-213261877e9e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c32c4d6b-8f2e-4054-b073-59f5caac2222"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2e76606e-d904-4b47-b7f1-a0daf4814fcb"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""623b36a0-c9b4-4ece-b1c2-f07e770a8769"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4cb11900-37cc-427a-a4a0-00b8b1f16437"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""f5fb7c21-8e8e-4422-9219-c3bdb335918d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""382f83cb-3c26-460f-bb13-bf8b46c8ac39"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0597c6ad-f22f-4dbf-90c1-809547a7d3fb"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""74b36c23-b8c3-4f19-a403-0599589c0f05"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c89aa19e-024f-4055-b1f2-13edfa98ca5e"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Interaction"",
            ""id"": ""75a9a081-5ae4-439f-ba9d-d9495b9f8a14"",
            ""actions"": [
                {
                    ""name"": ""Use"",
                    ""type"": ""Button"",
                    ""id"": ""ba9f2d6e-69bd-45de-9ab0-f510d9eb6948"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""216aaccd-4788-41c6-91f5-06604de0dc78"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_HorizontalMove = m_Movement.FindAction("HorizontalMove", throwIfNotFound: true);
        // Interaction
        m_Interaction = asset.FindActionMap("Interaction", throwIfNotFound: true);
        m_Interaction_Use = m_Interaction.FindAction("Use", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_HorizontalMove;
    public struct MovementActions
    {
        private @InputActions m_Wrapper;
        public MovementActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMove => m_Wrapper.m_Movement_HorizontalMove;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @HorizontalMove.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnHorizontalMove;
                @HorizontalMove.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnHorizontalMove;
                @HorizontalMove.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnHorizontalMove;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HorizontalMove.started += instance.OnHorizontalMove;
                @HorizontalMove.performed += instance.OnHorizontalMove;
                @HorizontalMove.canceled += instance.OnHorizontalMove;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Interaction
    private readonly InputActionMap m_Interaction;
    private IInteractionActions m_InteractionActionsCallbackInterface;
    private readonly InputAction m_Interaction_Use;
    public struct InteractionActions
    {
        private @InputActions m_Wrapper;
        public InteractionActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Use => m_Wrapper.m_Interaction_Use;
        public InputActionMap Get() { return m_Wrapper.m_Interaction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InteractionActions set) { return set.Get(); }
        public void SetCallbacks(IInteractionActions instance)
        {
            if (m_Wrapper.m_InteractionActionsCallbackInterface != null)
            {
                @Use.started -= m_Wrapper.m_InteractionActionsCallbackInterface.OnUse;
                @Use.performed -= m_Wrapper.m_InteractionActionsCallbackInterface.OnUse;
                @Use.canceled -= m_Wrapper.m_InteractionActionsCallbackInterface.OnUse;
            }
            m_Wrapper.m_InteractionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Use.started += instance.OnUse;
                @Use.performed += instance.OnUse;
                @Use.canceled += instance.OnUse;
            }
        }
    }
    public InteractionActions @Interaction => new InteractionActions(this);
    public interface IMovementActions
    {
        void OnHorizontalMove(InputAction.CallbackContext context);
    }
    public interface IInteractionActions
    {
        void OnUse(InputAction.CallbackContext context);
    }
}
