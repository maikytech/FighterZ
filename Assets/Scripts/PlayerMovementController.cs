using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{

    [SerializeField] private float speedPlayer;
    [SerializeField] private float speedRotation;

    private Vector3 playerInput;
    private Rigidbody playerRigidbody;
    private Animator playerAnimator;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
    }

    void MovementController()
    {
        float forwardMovement = Input.GetAxis("Horizontal");
        float rightMovement = Input.GetAxis("Vertical");
        playerInput.Set(forwardMovement, 0f, rightMovement);

        Vector3 newPositon = transform.position + playerInput.normalized * speedPlayer * Time.deltaTime;
        Quaternion forwardRotation = Quaternion.LookRotation(playerInput);

        playerRigidbody.MovePosition(newPositon);
        playerAnimator.SetFloat("Speed", playerInput.sqrMagnitude);

        if (playerRigidbody.rotation != forwardRotation)
            playerRigidbody.rotation = Quaternion.RotateTowards(playerRigidbody.rotation, forwardRotation, speedRotation * Time.deltaTime);
            
    }

    private void FixedUpdate()
    {
        MovementController();
    }
}
