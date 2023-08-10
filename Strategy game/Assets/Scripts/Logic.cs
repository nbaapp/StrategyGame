using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Logic : MonoBehaviour
{
    public InputActions inputActions;

    private Camera mapCamera;
    private UIManager uiManager;
    private PlayerUnit[] players;
    private EnemyUnit[] enemies;

    public bool isPlayerTurn = true;

    public float targetCameraSensitivity = 2f;

    // Start is called before the first frame update
    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
        mapCamera = GameObject.Find("Map Camera").GetComponent<Camera>();
        players = FindObjectsOfType<PlayerUnit>();
        enemies = FindObjectsOfType<EnemyUnit>();

        inputActions = new InputActions();
        inputActions.MapView.Enable();
        uiManager.ActivateMapUI();
        uiManager.UpdateTurnText();
    }

    public void SelectUnit(PlayerUnit unit)
    {
        if (isPlayerTurn)
        {
            inputActions.MapView.Disable();
            inputActions.UnitView.Enable();

            mapCamera.enabled = false;
            unit.unitCamera.enabled = true;
            unit.isSelected = true;

            unit.objectRenderer.material.color = Color.blue;

            uiManager.ActivateUnitMoveUI();
        }
    }

    public void LeaveUnitView(PlayerUnit unit)
    {
        if (inputActions.UnitView.LeaveUnitView.IsPressed() && unit.isSelected)
        {
            inputActions.UnitView.Disable();
            inputActions.MapView.Enable();

            unit.unitCamera.enabled = false;
            mapCamera.enabled = true;
            unit.isSelected = false;

            unit.hasMoved = true;
            unit.distanceLeft = unit.maxMoveDistance;

            uiManager.ActivateMapUI();
            EndPlayerTurn();
        }
    }

    public void EnterTargetingMode(PlayerUnit unit)
    {
        if (inputActions.UnitView.TargetingMode.IsPressed() && unit.isSelected)
        {
            inputActions.UnitView.Disable();
            inputActions.TargetingMode.Enable();

            unit.isTargeting = true;

            unit.targetingCamera.enabled = true;
            unit.unitCamera.enabled = false;

            unit.SetAttackRange();

            uiManager.ActivateTargetingUI();
        }
    }

    public void ExitTargetingMode(PlayerUnit unit)
    {
        if (inputActions.TargetingMode.UnitView.IsPressed() && unit.isTargeting)
        {
            inputActions.TargetingMode.Disable();
            inputActions.UnitView.Enable();

            unit.isTargeting = false;

            unit.unitCamera.enabled = true;
            unit.targetingCamera.enabled = false;

            unit.targetCamera.targetedEnemy = null;

            uiManager.ActivateUnitMoveUI();
        }
    }

    //function to end the player's turn when all player units have moved
    public void EndPlayerTurn()
    {
        foreach (PlayerUnit player in players)
        {
            if (!player.hasMoved)
            {
                return;
            }
        }

        isPlayerTurn = false;
        uiManager.UpdateTurnText();
        foreach (PlayerUnit player in players)
        {
            player.hasMoved = false;
        }
    }

    //function to end the enemy's turn when all enemy units have moved
    public void EndEnemyTurn()
    {
        foreach (EnemyUnit enemy in enemies)
        {
            if (!enemy.hasMoved)
            {
                return;
            }
        }

        isPlayerTurn = true;
        uiManager.UpdateTurnText();
        foreach (EnemyUnit enemy in enemies)
        {
            enemy.hasMoved = false;
        }
    }

    //function to find closest player unit to enemy unit
    public PlayerUnit FindClosestPlayerUnit(EnemyUnit enemy)
    {
        PlayerUnit closestPlayer = null;
        float closestDistance = Mathf.Infinity;

        foreach (PlayerUnit player in players)
        {
            float distance = Vector3.Distance(enemy.transform.position, player.transform.position);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestPlayer = player;
            }
        }

        return closestPlayer;
    }    

}
