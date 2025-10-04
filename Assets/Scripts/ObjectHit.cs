using System;
using UnityEngine;
using Random = System.Random;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(gameObject.name + " collided with " + other.gameObject.name + " this object has tag " + other.gameObject.tag + " and " + (other.gameObject.CompareTag("Player") ? "is" : "is not") + " the Player");

        if (gameObject.CompareTag("Hit")) // Check if already hit
        {
            Debug.Log("Already hit, ignoring.");
            return; 
        }
        
        if (!other.gameObject.CompareTag("Player"))
        {
            return; 
        }
        
        gameObject.tag = "Hit";

        var currentMaterial = GetComponent<Renderer>().sharedMaterial; // Use sharedMaterial for comparison
    
        Debug.Log("Current material is " + currentMaterial);
     
    
        if (currentMaterial == MaterialManager.Hit1)
        {
            Debug.Log("Branch 1 assigning Sofia's Colour material");
            GetComponent<Renderer>().material = MaterialManager.Hit2; // Still use .material for assignment
        }
        else if (currentMaterial == MaterialManager.Hit2)
        {
            Debug.Log("Branch 2 assingning TouchedObject material");
            GetComponent<Renderer>().material = MaterialManager.Hit1;
        }
        else
        {
            Debug.Log("Branch 3");
            var number = UnityEngine.Random.Range(1, 3);
            GetComponent<Renderer>().material = (number == 1 ? MaterialManager.Hit1 : MaterialManager.Hit2);
        }
    }
}
