using System;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class FlyTowardsPlayer : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector3 targetPosition;
    private bool isMoving = false;
    
    public void StartMovingTowardsPlayer(Transform playerPosition)
    {
        targetPosition = playerPosition.position;

        isMoving = true;
    }

    private void FixedUpdate()
    {
        if (!isMoving) return;
        
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
