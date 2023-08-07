using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;

    private void Start()
    {
        healthBar = gameObject.GetComponent<Slider>();
    }

    private void Update()
    {
        if (Camera.current != null)
        {
            transform.LookAt(Camera.current.transform);
        }
    }
    public void UpdateHealthBar(float health, float maxHealth)
    {
        if (healthBar != null)
        {
            healthBar.value = health / maxHealth;
        }
    }
    
}
