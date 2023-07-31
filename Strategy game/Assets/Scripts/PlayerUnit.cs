using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : MonoBehaviour
{
    private InputActions inputActions;
    private Logic logic;
    private CharacterController controller;
    public Camera unitCamera;
    public Renderer objectRenderer;

    public float moveSpeed = 10f;
    public float turnSpeed = 60f;

    public bool isSelected;
    // Start is called before the first frame update
    void Start()
    {
        objectRenderer = gameObject.GetComponent<Renderer>();
        logic = GameObject.Find("Logic").GetComponent<Logic>();
        unitCamera = transform.Find("Unit Camera").GetComponent<Camera>();
        inputActions = logic.inputActions;
        controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        logic.LeaveUnitView(this);
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        Vector2 moveDirection = inputActions.UnitView.Move.ReadValue<Vector2>().normalized;
        float horizontal = moveDirection.x * turnSpeed * Time.deltaTime;
        float vertical = moveDirection.y * moveSpeed * Time.deltaTime;

        transform.Rotate(0, horizontal , 0);
        controller.Move(transform.TransformDirection(new Vector3(0, 0, vertical)));

    }

    // when mouse hovers over unit
    private void OnMouseEnter()
    {
        if (inputActions.MapView.enabled)
        {
            objectRenderer.material.color = Color.green;
        }
    }

    // when mouse leaves unit
    private void OnMouseExit()
    {
        if (inputActions.MapView.enabled)
        {
            objectRenderer.material.color = Color.blue;
        }
    }

    // when unit is clicked
    private void OnMouseDown()
    {
        if (inputActions.MapView.enabled)
        {
            logic.SelectUnit(this);
        }
    }
}
