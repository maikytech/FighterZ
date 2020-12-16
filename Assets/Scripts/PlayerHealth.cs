using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int startingHealth;
    [SerializeField] private int currentHealth;

    [SerializeField] private bool isDead;
    private bool damaged;
    private Animator playerAnimator;
    private PlayerMovementController playerMovement;

    private void Awake()
    {
        playerAnimator = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovementController>();
    }

    private void Start()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamaged()
    {
        
        //currentHealth -= damage;

        if (currentHealth <= 0 && !isDead)
            Death();
    }

    void Death()
    {
        isDead = true;
        playerMovement.enabled = false;   
    }

    private void Update()
    {
        TakeDamaged();
    }
}
