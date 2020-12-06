using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{

    [SerializeField] private float speedPlayer;

    private Vector3 playerInput;
    private Rigidbody playerRigidbody;
    private Animator playerAnimator;

    private void Awake()
    {
        speedPlayer = 2.0f;
        playerRigidbody = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
    }

    void MovementController()
    {
        float forwardMovement = Input.GetAxis("Horizontal");
        float rightMovement = Input.GetAxis("Vertical");
        playerInput.Set(forwardMovement, 0f, rightMovement);

        Vector3 newPositon = transform.position + playerInput.normalized * speedPlayer * Time.deltaTime;

        playerRigidbody.MovePosition(newPositon);

        playerAnimator.SetFloat("Speed", playerInput.sqrMagnitude);     

    }

    private void FixedUpdate()
    {
        MovementController();
    }



}
