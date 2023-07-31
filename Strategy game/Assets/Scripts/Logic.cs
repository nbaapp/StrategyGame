using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Logic : MonoBehaviour
{
    public InputActions inputActions;

    private Camera mapCamera;

    // Start is called before the first frame update
    void Start()
    {
        mapCamera = GameObject.Find("Map Camera").GetComponent<Camera>();

        inputActions = new InputActions();
        inputActions.MapView.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectUnit(PlayerUnit unit)
    {
        inputActions.MapView.Disable();
        inputActions.UnitView.Enable();

        mapCamera.enabled = false;
        unit.unitCamera.enabled = true;

        unit.isSelected = true;
        unit.objectRenderer.material.color = Color.blue;
    }

    public void LeaveUnitView(PlayerUnit unit)
    {
        if (inputActions.UnitView.LeaveUnitView.IsPressed())
        {
            inputActions.UnitView.Disable();
            inputActions.MapView.Enable();

            unit.unitCamera.enabled = false;
            mapCamera.enabled = true;

            unit.isSelected = false;
        }
    }
}
