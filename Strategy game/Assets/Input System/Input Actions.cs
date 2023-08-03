//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Input System/Input Actions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input Actions"",
    ""maps"": [
        {
            ""name"": ""Unit View"",
            ""id"": ""4c7ff4a9-6b06-4f20-b4bd-d667d46fcfe9"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""08570d70-c280-43fc-ab6e-70e7d7bf7154"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Move Camera"",
                    ""type"": ""Value"",
                    ""id"": ""fd7d263e-fcd1-491a-a986-2e4c6337ed6e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Leave Unit View"",
                    ""type"": ""Button"",
                    ""id"": ""e9cd6310-61d3-4e9a-8756-64fe0ae9cb52"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Camera Select"",
                    ""type"": ""Button"",
                    ""id"": ""ea6add19-4beb-4621-b848-5b16d626b4c4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Targeting Mode"",
                    ""type"": ""Button"",
                    ""id"": ""36f425d6-b62e-4cec-8e6f-24948f201c63"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""1efc1825-fdf4-4415-8e33-1fea24ca2edc"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e9dddf5c-e41c-4bce-a4ef-a35c84c58963"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2ab4fac1-c4ea-4594-9f01-7de59704a754"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""39323e4c-8cdc-4ca1-8ddf-e930d149be72"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""546660a1-c236-4831-92af-4c806d0ea2e6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""05a68587-cc4f-449d-b566-e6def344419a"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""879d484e-1cd1-45b7-b9c5-f4745877dcfc"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Leave Unit View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""69f27c21-485d-4f61-8be4-bc5249a7bfaa"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""57a62b19-1a14-48dd-bd6b-c324815b3ef1"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Targeting Mode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Map View"",
            ""id"": ""ba698fb1-def0-44fd-8460-a6f3fb450d6c"",
            ""actions"": [
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""918c2814-d189-47d3-a175-da34324a6441"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Cursor"",
                    ""type"": ""Value"",
                    ""id"": ""faa234de-089d-4881-b431-90270bf03464"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""af768ff9-e3c6-424b-a340-8e9bde18263f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0bacf345-8834-4a51-8e7d-633e18b2bd80"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Cursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Targeting Mode"",
            ""id"": ""47e91619-d765-4f31-afd5-4613a33853ec"",
            ""actions"": [
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""fa38b9a9-53e0-49dd-9b37-2d887dd3b0df"",
                    ""expectedControlType"": ""Delta"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Select Action"",
                    ""type"": ""Button"",
                    ""id"": ""78db09c1-49d4-4933-94a5-50a27f177231"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Perform Action"",
                    ""type"": ""Button"",
                    ""id"": ""cc9a3950-f933-4669-b2cd-303d07379319"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Unit View"",
                    ""type"": ""Button"",
                    ""id"": ""e25693af-6333-4557-922c-1ff8ac0e7047"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Enable Aim"",
                    ""type"": ""Button"",
                    ""id"": ""ff0948dc-67c0-4b0e-9af9-2e50673cec00"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""95afeb39-7ec6-4a54-b59e-6e754f84b3b4"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e5650d5-d1cc-4ec8-ab32-dc9716de6ee4"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Select Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""885a3b79-a9b2-4ad4-b8e1-0d70eacca00a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Perform Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""120b07cc-825b-43f5-9851-4d09b3a892d5"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Unit View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d816ca6-c91c-48ad-bfd6-2e0afb2a1abc"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Enable Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
            ""devices"": []
        }
    ]
}");
        // Unit View
        m_UnitView = asset.FindActionMap("Unit View", throwIfNotFound: true);
        m_UnitView_Move = m_UnitView.FindAction("Move", throwIfNotFound: true);
        m_UnitView_MoveCamera = m_UnitView.FindAction("Move Camera", throwIfNotFound: true);
        m_UnitView_LeaveUnitView = m_UnitView.FindAction("Leave Unit View", throwIfNotFound: true);
        m_UnitView_CameraSelect = m_UnitView.FindAction("Camera Select", throwIfNotFound: true);
        m_UnitView_TargetingMode = m_UnitView.FindAction("Targeting Mode", throwIfNotFound: true);
        // Map View
        m_MapView = asset.FindActionMap("Map View", throwIfNotFound: true);
        m_MapView_Select = m_MapView.FindAction("Select", throwIfNotFound: true);
        m_MapView_Cursor = m_MapView.FindAction("Cursor", throwIfNotFound: true);
        // Targeting Mode
        m_TargetingMode = asset.FindActionMap("Targeting Mode", throwIfNotFound: true);
        m_TargetingMode_Aim = m_TargetingMode.FindAction("Aim", throwIfNotFound: true);
        m_TargetingMode_SelectAction = m_TargetingMode.FindAction("Select Action", throwIfNotFound: true);
        m_TargetingMode_PerformAction = m_TargetingMode.FindAction("Perform Action", throwIfNotFound: true);
        m_TargetingMode_UnitView = m_TargetingMode.FindAction("Unit View", throwIfNotFound: true);
        m_TargetingMode_EnableAim = m_TargetingMode.FindAction("Enable Aim", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Unit View
    private readonly InputActionMap m_UnitView;
    private List<IUnitViewActions> m_UnitViewActionsCallbackInterfaces = new List<IUnitViewActions>();
    private readonly InputAction m_UnitView_Move;
    private readonly InputAction m_UnitView_MoveCamera;
    private readonly InputAction m_UnitView_LeaveUnitView;
    private readonly InputAction m_UnitView_CameraSelect;
    private readonly InputAction m_UnitView_TargetingMode;
    public struct UnitViewActions
    {
        private @InputActions m_Wrapper;
        public UnitViewActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_UnitView_Move;
        public InputAction @MoveCamera => m_Wrapper.m_UnitView_MoveCamera;
        public InputAction @LeaveUnitView => m_Wrapper.m_UnitView_LeaveUnitView;
        public InputAction @CameraSelect => m_Wrapper.m_UnitView_CameraSelect;
        public InputAction @TargetingMode => m_Wrapper.m_UnitView_TargetingMode;
        public InputActionMap Get() { return m_Wrapper.m_UnitView; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UnitViewActions set) { return set.Get(); }
        public void AddCallbacks(IUnitViewActions instance)
        {
            if (instance == null || m_Wrapper.m_UnitViewActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_UnitViewActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @MoveCamera.started += instance.OnMoveCamera;
            @MoveCamera.performed += instance.OnMoveCamera;
            @MoveCamera.canceled += instance.OnMoveCamera;
            @LeaveUnitView.started += instance.OnLeaveUnitView;
            @LeaveUnitView.performed += instance.OnLeaveUnitView;
            @LeaveUnitView.canceled += instance.OnLeaveUnitView;
            @CameraSelect.started += instance.OnCameraSelect;
            @CameraSelect.performed += instance.OnCameraSelect;
            @CameraSelect.canceled += instance.OnCameraSelect;
            @TargetingMode.started += instance.OnTargetingMode;
            @TargetingMode.performed += instance.OnTargetingMode;
            @TargetingMode.canceled += instance.OnTargetingMode;
        }

        private void UnregisterCallbacks(IUnitViewActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @MoveCamera.started -= instance.OnMoveCamera;
            @MoveCamera.performed -= instance.OnMoveCamera;
            @MoveCamera.canceled -= instance.OnMoveCamera;
            @LeaveUnitView.started -= instance.OnLeaveUnitView;
            @LeaveUnitView.performed -= instance.OnLeaveUnitView;
            @LeaveUnitView.canceled -= instance.OnLeaveUnitView;
            @CameraSelect.started -= instance.OnCameraSelect;
            @CameraSelect.performed -= instance.OnCameraSelect;
            @CameraSelect.canceled -= instance.OnCameraSelect;
            @TargetingMode.started -= instance.OnTargetingMode;
            @TargetingMode.performed -= instance.OnTargetingMode;
            @TargetingMode.canceled -= instance.OnTargetingMode;
        }

        public void RemoveCallbacks(IUnitViewActions instance)
        {
            if (m_Wrapper.m_UnitViewActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IUnitViewActions instance)
        {
            foreach (var item in m_Wrapper.m_UnitViewActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_UnitViewActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public UnitViewActions @UnitView => new UnitViewActions(this);

    // Map View
    private readonly InputActionMap m_MapView;
    private List<IMapViewActions> m_MapViewActionsCallbackInterfaces = new List<IMapViewActions>();
    private readonly InputAction m_MapView_Select;
    private readonly InputAction m_MapView_Cursor;
    public struct MapViewActions
    {
        private @InputActions m_Wrapper;
        public MapViewActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Select => m_Wrapper.m_MapView_Select;
        public InputAction @Cursor => m_Wrapper.m_MapView_Cursor;
        public InputActionMap Get() { return m_Wrapper.m_MapView; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MapViewActions set) { return set.Get(); }
        public void AddCallbacks(IMapViewActions instance)
        {
            if (instance == null || m_Wrapper.m_MapViewActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MapViewActionsCallbackInterfaces.Add(instance);
            @Select.started += instance.OnSelect;
            @Select.performed += instance.OnSelect;
            @Select.canceled += instance.OnSelect;
            @Cursor.started += instance.OnCursor;
            @Cursor.performed += instance.OnCursor;
            @Cursor.canceled += instance.OnCursor;
        }

        private void UnregisterCallbacks(IMapViewActions instance)
        {
            @Select.started -= instance.OnSelect;
            @Select.performed -= instance.OnSelect;
            @Select.canceled -= instance.OnSelect;
            @Cursor.started -= instance.OnCursor;
            @Cursor.performed -= instance.OnCursor;
            @Cursor.canceled -= instance.OnCursor;
        }

        public void RemoveCallbacks(IMapViewActions instance)
        {
            if (m_Wrapper.m_MapViewActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMapViewActions instance)
        {
            foreach (var item in m_Wrapper.m_MapViewActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MapViewActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MapViewActions @MapView => new MapViewActions(this);

    // Targeting Mode
    private readonly InputActionMap m_TargetingMode;
    private List<ITargetingModeActions> m_TargetingModeActionsCallbackInterfaces = new List<ITargetingModeActions>();
    private readonly InputAction m_TargetingMode_Aim;
    private readonly InputAction m_TargetingMode_SelectAction;
    private readonly InputAction m_TargetingMode_PerformAction;
    private readonly InputAction m_TargetingMode_UnitView;
    private readonly InputAction m_TargetingMode_EnableAim;
    public struct TargetingModeActions
    {
        private @InputActions m_Wrapper;
        public TargetingModeActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Aim => m_Wrapper.m_TargetingMode_Aim;
        public InputAction @SelectAction => m_Wrapper.m_TargetingMode_SelectAction;
        public InputAction @PerformAction => m_Wrapper.m_TargetingMode_PerformAction;
        public InputAction @UnitView => m_Wrapper.m_TargetingMode_UnitView;
        public InputAction @EnableAim => m_Wrapper.m_TargetingMode_EnableAim;
        public InputActionMap Get() { return m_Wrapper.m_TargetingMode; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TargetingModeActions set) { return set.Get(); }
        public void AddCallbacks(ITargetingModeActions instance)
        {
            if (instance == null || m_Wrapper.m_TargetingModeActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_TargetingModeActionsCallbackInterfaces.Add(instance);
            @Aim.started += instance.OnAim;
            @Aim.performed += instance.OnAim;
            @Aim.canceled += instance.OnAim;
            @SelectAction.started += instance.OnSelectAction;
            @SelectAction.performed += instance.OnSelectAction;
            @SelectAction.canceled += instance.OnSelectAction;
            @PerformAction.started += instance.OnPerformAction;
            @PerformAction.performed += instance.OnPerformAction;
            @PerformAction.canceled += instance.OnPerformAction;
            @UnitView.started += instance.OnUnitView;
            @UnitView.performed += instance.OnUnitView;
            @UnitView.canceled += instance.OnUnitView;
            @EnableAim.started += instance.OnEnableAim;
            @EnableAim.performed += instance.OnEnableAim;
            @EnableAim.canceled += instance.OnEnableAim;
        }

        private void UnregisterCallbacks(ITargetingModeActions instance)
        {
            @Aim.started -= instance.OnAim;
            @Aim.performed -= instance.OnAim;
            @Aim.canceled -= instance.OnAim;
            @SelectAction.started -= instance.OnSelectAction;
            @SelectAction.performed -= instance.OnSelectAction;
            @SelectAction.canceled -= instance.OnSelectAction;
            @PerformAction.started -= instance.OnPerformAction;
            @PerformAction.performed -= instance.OnPerformAction;
            @PerformAction.canceled -= instance.OnPerformAction;
            @UnitView.started -= instance.OnUnitView;
            @UnitView.performed -= instance.OnUnitView;
            @UnitView.canceled -= instance.OnUnitView;
            @EnableAim.started -= instance.OnEnableAim;
            @EnableAim.performed -= instance.OnEnableAim;
            @EnableAim.canceled -= instance.OnEnableAim;
        }

        public void RemoveCallbacks(ITargetingModeActions instance)
        {
            if (m_Wrapper.m_TargetingModeActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ITargetingModeActions instance)
        {
            foreach (var item in m_Wrapper.m_TargetingModeActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_TargetingModeActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public TargetingModeActions @TargetingMode => new TargetingModeActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    public interface IUnitViewActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnMoveCamera(InputAction.CallbackContext context);
        void OnLeaveUnitView(InputAction.CallbackContext context);
        void OnCameraSelect(InputAction.CallbackContext context);
        void OnTargetingMode(InputAction.CallbackContext context);
    }
    public interface IMapViewActions
    {
        void OnSelect(InputAction.CallbackContext context);
        void OnCursor(InputAction.CallbackContext context);
    }
    public interface ITargetingModeActions
    {
        void OnAim(InputAction.CallbackContext context);
        void OnSelectAction(InputAction.CallbackContext context);
        void OnPerformAction(InputAction.CallbackContext context);
        void OnUnitView(InputAction.CallbackContext context);
        void OnEnableAim(InputAction.CallbackContext context);
    }
}
