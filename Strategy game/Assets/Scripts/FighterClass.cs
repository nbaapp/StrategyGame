using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Actions
{
    Attack,
    Defend,
    Dash
}

public class FighterClass : MonoBehaviour
{
    private Logic logic;
    private UIManager uiManager;
    private PlayerUnit unit;
    public Actions action = Actions.Attack;

    public int numberOfActoins = 2;
    public float attackRange = 5f;

    public bool isDefending = false;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.Find("Logic").GetComponent<Logic>();
        uiManager = FindObjectOfType<UIManager>();
        unit = gameObject.GetComponent<PlayerUnit>();
        
        unit.targetingArea.transform.localScale = new Vector3(attackRange * 2, unit.targetingArea.transform.localScale.y, attackRange * 2);

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
                action = Actions.Defend;
                uiManager.UpdateSelectedActionText("Defend");
            }
            else if (action == Actions.Defend)
            {
                action = Actions.Dash;
                uiManager.UpdateSelectedActionText("Dash");
            }
            else if (action == Actions.Dash)
            {
                action = Actions.Attack;
                uiManager.UpdateSelectedActionText("Attack");
            }
        }
    }

    //function to perform the action
    public void PerformAction()
    {
        if (logic.inputActions.TargetingMode.PerformAction.triggered && unit.isTargeting && numberOfActoins >= 0)
        {
            numberOfActoins--;
            if (action == Actions.Attack)
            {
                Debug.Log("Attack");
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