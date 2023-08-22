using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageClass : MonoBehaviour
{
    private enum Actions
    {
        Attack,
        Fireball,
        Defend,
        Dash
    }

    private Logic logic;
    private UIManager uiManager;
    private PlayerUnit unit;
    private Animator animator;
    public GameObject fireball;
    private Actions action = Actions.Attack;

    public int actionPoints = 2;

    public float mainAttackRange = 5f;
    public float mainAttackDamage = 10f;

    public float fireballAttackRange = 10f;

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
                //switch to fireball
                action = Actions.Fireball;
                uiManager.UpdateSelectedActionText("Fireball");

                currentAttackRange = fireballAttackRange;
                unit.attackRange = currentAttackRange;
            }
            else if (action == Actions.Fireball)
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
            uiManager.UpdateAPText(actionPoints);
            if (action == Actions.Attack)
            {
                Attack();
            }
            if (action == Actions.Fireball && actionPoints >= 2)
            {
                Fireball();
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
        animator.SetTrigger("Mage Attack");
        if (unit.targetCamera.targetedEnemy != null)
        {
            unit.targetCamera.targetedEnemy.TakeDamage(mainAttackDamage);
        }
        actionPoints--;
    }

    //fireball function
    private void Fireball()
    {
        animator.SetTrigger("Mage Fireball");

        TargetingCamera camera = unit.targetingCamera.GetComponent<TargetingCamera>();

        if (camera.isActiveAndEnabled)
        {
            RaycastHit hitInfo;

            if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hitInfo, Mathf.Infinity))
            {
                if (hitInfo.transform.gameObject.layer == 10 && hitInfo.distance < fireballAttackRange)
                {
                    Instantiate(fireball, hitInfo.point, Quaternion.identity);
                }
            }
        }
        actionPoints -= 2;
    }

    //defend function
    private void Defend()
    {
        isDefending = true;
        actionPoints--;
    }

    //dash function
    private void Dash()
    {
        unit.distanceLeft += unit.maxMoveDistance;
        actionPoints--;
    }
}
