using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetingCamera : MonoBehaviour
{
    private Logic logic;
    private GameObject unit;

    public float sensitivity = 1f;
    // Start is called before the first frame update
    void Start()
    {
        unit = transform.parent.gameObject;
        logic = GameObject.Find("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        RotateCamera();
    }

    void RotateCamera()
    {
        if (logic.inputActions.TargetingMode.EnableAim.IsPressed())
        {
            Vector2 rotation = logic.inputActions.TargetingMode.Aim.ReadValue<Vector2>();
            transform.RotateAround(transform.position, Vector3.up, rotation.x * sensitivity);
            transform.RotateAround(transform.position, transform.right, -rotation.y * sensitivity);
        }
    }
}
