using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnit : MonoBehaviour
{
    private Logic logic;
    private CharacterController controller;

    public float maxHealth = 100f;
    public float health;

    public float movespeed = 10f;
    public float turnSpeed = 60f;
    public float maxMoveDistance = 10f;
    public float distanceLeft = 10f;
    public float attackRange = 1f;

    public bool hasMoved = false;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.Find("Logic").GetComponent<Logic>();
        controller = gameObject.GetComponent<CharacterController>();
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //function to take damage when hit
    public void TakeDamage(float damage)
    {
        health -= damage;
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
