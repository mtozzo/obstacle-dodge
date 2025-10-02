using System;
using UnityEngine;

public class FlyTowardsPlayer : MonoBehaviour
{
    [SerializeField] private Transform playerPosition;
    [SerializeField] private float speed;
    private Vector3 targetPosition;

    private void Start()
    {
        targetPosition = playerPosition.position;
    }

    private void FixedUpdate()
    {
        MoveToPlayer();
        DestroyWhenDestinationReached();
    }

    private void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * speed);        
    }
    
    private void DestroyWhenDestinationReached()
    {
        if (transform.position == targetPosition)
        {
            Destroy(gameObject);
        }
    }
}
