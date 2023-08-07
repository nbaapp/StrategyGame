using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public Logic logic;
    public TextMeshProUGUI turnText;
    public TextMeshProUGUI selectedActionText;
    public TextMeshProUGUI apText;
    public GameObject mapUI;
    public GameObject unitMoveUI;
    public GameObject targetingUI;

    // Start is called before the first frame update
    void Start()
    {

    }

    //activate unit move UI and deactivate all other UI
    public void ActivateUnitMoveUI()
    {
        mapUI.SetActive(false);
        targetingUI.SetActive(false);
        unitMoveUI.SetActive(true);
    }

    //activate targeting UI and deactivate all other UI
    public void ActivateTargetingUI()
    {
        unitMoveUI.SetActive(false);
        targetingUI.SetActive(false);
        targetingUI.SetActive(true);
    }

    //activate map UI and deactivate all other UI
    public void ActivateMapUI()
    {
        unitMoveUI.SetActive(false);
        targetingUI.SetActive(false);
        mapUI.SetActive(true);
    }

    //update the AP text with the current AP
    public void UpdateAPText(int ap)
    {
        apText.text = "AP: " + ap;
    }

    //update the selected action text
    public void UpdateSelectedActionText(string text)
    {
        selectedActionText.text = text;
    }

    public void UpdateTurnText()
    {
        if (logic.isPlayerTurn)
        {
            turnText.text = "Player Turn";
            turnText.color = Color.blue;
        }
        else
        {
            turnText.text = "Enemy Turn";
            turnText.color = Color.red;
        }
    }
}
