using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{

    [SerializeField] private float speedPlayer;

    private Vector3 playerInput;
    private Rigidbody playerRigidbody;

    private void Awake()
    {
        speedPlayer = 5.0f;
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void MovementController()
    {
        float forwardMovement = Input.GetAxis("Horizontal");
        float rightMovement = Input.GetAxis("Vertical");
        playerInput.Set(forwardMovement, 0f, rightMovement);

        Vector3 newPositon = transform.position + playerInput.normalized * speedPlayer * Time.deltaTime;

        playerRigidbody.MovePosition(newPositon);

    }

    private void FixedUpdate()
    {
        MovementController();
    }



}
