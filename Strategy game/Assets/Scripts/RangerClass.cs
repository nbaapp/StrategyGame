using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangerClass : MonoBehaviour
{
    private enum Actions
    {
        Attack,
        Defend,
        Dash
    }

    private Logic logic;
    private UIManager uiManager;
    private PlayerUnit unit;
    private Animator animator;
    private Actions action = Actions.Attack;

    public GameObject arrow;

    public int actionPoints = 2;

    public float mainAttackRange = 5f;
    public float mainAttackDamage = 10f;
    public float shootPower = 50;

    public float currentAttackRange;

    public bool isDefending = false;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.Find("Logic").GetComponent<Logic>();
        uiManager = FindObjectOfType<UIManager>();
        unit = gameObject.GetComponent<PlayerUnit>();
        animator = gameObject.GetComponent<Animator>();

        currentAttackRange = mainAttackRange;

        uiManager.UpdateSelectedActionText(action.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        logic.ExitTargetingMode(unit);
        SwitchAction();
        PerformAction();
    }

    //function to switch between actions
    public void SwitchAction()
    {
        if (logic.inputActions.TargetingMode.SelectAction.triggered && unit.isSelected)
        {
            if (action == Actions.Attack)
            {
                //switch to defend
                action = Actions.Defend;
                uiManager.UpdateSelectedActionText("Defend");
            }
            else if (action == Actions.Defend)
            {
                //switch to dash
                action = Actions.Dash;
                uiManager.UpdateSelectedActionText("Dash");
            }
            else if (action == Actions.Dash)
            {
                //switch to attack
                action = Actions.Attack;
                uiManager.UpdateSelectedActionText("Attack");

                currentAttackRange = mainAttackRange;
                unit.attackRange = currentAttackRange;
            }
        }
    }

    //function to perform the action
    public void PerformAction()
    {
        if (logic.inputActions.TargetingMode.PerformAction.triggered && unit.isTargeting && actionPoints > 0)
        {
            actionPoints--;
            uiManager.UpdateAPText(actionPoints);
            if (action == Actions.Attack)
            {
                Attack();
            }
            
            else if (action == Actions.Defend)
            {
                Defend();
            }
            else if (action == Actions.Dash)
            {
                Dash();
            }
        }
    }

    //attack function
    private void Attack()
    {
        animator.SetTrigger("Ranger Attack");
        GameObject arrowFired = Instantiate(arrow, transform, false);
        arrowFired.GetComponent<Rigidbody>().velocity = transform.forward * shootPower;
        if (unit.targetCamera.targetedEnemy != null)
        {
            unit.targetCamera.targetedEnemy.TakeDamage(mainAttackDamage);
        }
    }

    //defend function
    private void Defend()
    {
        isDefending = true;
    }

    //dash function
    private void Dash()
    {
        unit.distanceLeft += unit.maxMoveDistance;
    }
}
