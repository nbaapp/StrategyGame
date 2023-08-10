using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerUnit : MonoBehaviour
{
    private Logic logic;
    private CharacterController controller;
    public Camera unitCamera;
    public Camera targetingCamera;
    public Renderer objectRenderer;
    private HealthBar healthBar;
    public TargetingCamera targetCamera;

    public float attackRange;

    public float maxHealth = 100f;
    public float health;

    public float moveSpeed = 10f;
    public float turnSpeed = 60f;
    public float maxMoveDistance = 10f;
    public float distanceLeft = 10f;

    public bool isSelected = false;
    public bool isTargeting = false;
    public bool hasMoved = false;

    // Start is called before the first frame update
    void Start()
    {
        objectRenderer = gameObject.GetComponent<Renderer>();
        logic = GameObject.Find("Logic").GetComponent<Logic>();
        unitCamera = transform.Find("Unit Camera").GetComponent<Camera>();
        targetingCamera = transform.Find("Targeting Camera").GetComponent<Camera>();
        controller = gameObject.GetComponent<CharacterController>();
        healthBar = gameObject.GetComponentInChildren<HealthBar>();
        targetCamera = gameObject.GetComponentInChildren<TargetingCamera>();

        health = maxHealth;
        healthBar.UpdateHealthBar(health, maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        logic.LeaveUnitView(this);
        logic.EnterTargetingMode(this);
    }

    private void FixedUpdate()
    {
        Move();
    }

    public void SetAttackRange()
    {
        if (GetComponent<MageClass>() != null)
        {
            MageClass mage = GetComponent<MageClass>();
            attackRange = mage.currentAttackRange;
        }
        else if (GetComponent<RangerClass>() != null)
        {
            RangerClass ranger = GetComponent<RangerClass>();
            attackRange = ranger.currentAttackRange;
        }
        else if (GetComponent<TheifClass>() != null)
        {
            TheifClass theif = GetComponent<TheifClass>();
            attackRange = theif.currentAttackRange;
        }
        else if (GetComponent<FighterClass>() != null)
        {
            FighterClass fighter = GetComponent<FighterClass>();
            attackRange = fighter.currentAttackRange;
        }
    }

    private void Move()
    {
        if(isSelected)
        {
            Vector2 moveDirection = logic.inputActions.UnitView.Move.ReadValue<Vector2>().normalized;
            float horizontal = moveDirection.x * turnSpeed * Time.deltaTime;
            float vertical = moveDirection.y * moveSpeed * Time.deltaTime;

            transform.Rotate(0, horizontal, 0);
            if (distanceLeft >= 0)
            {
                controller.Move(transform.TransformDirection(new Vector3(0, 0, vertical)));

                if (Mathf.Abs(vertical) > 0)
                {
                    distanceLeft -= Time.deltaTime;
                }
            }
        }
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        healthBar.UpdateHealthBar(health, maxHealth);
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    // when mouse hovers over unit
    private void OnMouseEnter()
    {
        if (logic.inputActions.MapView.enabled && !hasMoved)
        {
            objectRenderer.material.color = Color.green;
        }
    }

    // when mouse leaves unit
    private void OnMouseExit()
    {
        if (logic.inputActions.MapView.enabled && !hasMoved)
        {
            objectRenderer.material.color = Color.blue;
        }
    }

    // when unit is clicked
    private void OnMouseDown()
    {
        if (logic.inputActions.MapView.enabled && !hasMoved)
        {
            logic.SelectUnit(this);
        }
    }

    
}
