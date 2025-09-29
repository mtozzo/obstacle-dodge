using UnityEngine;

public class FlyTowardsPlayer : MonoBehaviour
{
    [SerializeField] private Transform playerPosition;
    [SerializeField] private float speed = 5f;
    
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition.position, 0.1f * Time.deltaTime * speed);
    }
}
