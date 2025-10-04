using System;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    [SerializeField] private GameObject connectedProjectile;
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name + " collided with " + other.gameObject.name + " this object has tag " + other.gameObject.tag +
                  " and " + (other.gameObject.CompareTag("Player") ? "is" : "is not") + " the Player");
        
        Debug.Log("Launching projectile!");
        
        connectedProjectile.GetComponent<FlyTowardsPlayer>().StartMovingTowardsPlayer(other.transform);
    }
}
