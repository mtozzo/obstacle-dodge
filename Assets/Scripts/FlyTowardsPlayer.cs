using UnityEngine;

public class FlyTowardsPlayer : MonoBehaviour
{
    [SerializeField] private Transform playerPosition;
    [SerializeField] private float speed = 5f;

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition.position, 0.1f * Time.deltaTime * speed);
    }
}
