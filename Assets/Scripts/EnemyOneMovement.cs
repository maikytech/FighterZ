using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyOneMovement : MonoBehaviour
{
    private Transform playerTransform;
    private NavMeshAgent naveMeshEnemy;

    private void Awake()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        naveMeshEnemy = GetComponent<NavMeshAgent>();
    }

    private void Follow()
    {
        naveMeshEnemy.SetDestination(playerTransform.position);
    }

    private void Update()
    {
        Follow();
    }
}
