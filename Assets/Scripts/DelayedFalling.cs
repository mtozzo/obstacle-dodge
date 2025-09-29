using UnityEngine;

public class DelayedFalling : MonoBehaviour
{
    [SerializeField] private float delay = 3f;
    private bool gravityEnabled = false;

    private void FixedUpdate()
    {
        if (gravityEnabled || !(Time.time > delay)) return;
        
        gravityEnabled = true;
        var rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
        Debug.Log("useGravity after delay: " + rb.useGravity);
        Destroy(this); // Remove this component after enabling gravity
    }
}
