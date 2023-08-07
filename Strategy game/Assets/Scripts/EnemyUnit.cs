using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnit : MonoBehaviour
{
    private Logic logic;
    private CharacterController controller;
    private HealthBar healthBar;

    public float maxHealth = 100f;
    public float health;

    public float movespeed = 10f;
    public float turnSpeed = 60f;
    public float maxMoveDistance = 10f;
    public float distanceLeft = 10f;
    public float attackRange = 1f;

    public bool isTargeted = false;
    public bool hasMoved = false;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.Find("Logic").GetComponent<Logic>();
        controller = gameObject.GetComponent<CharacterController>();
        healthBar = gameObject.GetComponentInChildren<HealthBar>();

        health = maxHealth;
        healthBar.UpdateHealthBar(health, maxHealth);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            if (other.transform.GetComponentInParent<FighterClass>() != null)
            {
                FighterClass incomingAttacker = other.transform.GetComponentInParent<FighterClass>();
                TakeDamage(incomingAttacker.mainAttackDamage);
            }
            else if (other.transform.GetComponentInParent<MageClass>() != null)
            {
                MageClass incomingAttacker = other.transform.GetComponentInParent<MageClass>();
                TakeDamage(incomingAttacker.mainAttackDamage);
            }
            else if (other.transform.GetComponentInParent<TheifClass>() != null)
            {
                TheifClass incomingAttacker = other.transform.GetComponentInParent<TheifClass>();
                TakeDamage(incomingAttacker.mainAttackDamage);
            }
        }
    }

    //function to take damage when hit
    public void TakeDamage(float damage)
    {
        health -= damage;
        healthBar.UpdateHealthBar(health, maxHealth);
        if (health <= 0)
        {
            Die();
        }
    }

    //function to die
    public void Die()
    {
        Destroy(gameObject);
    }

}
