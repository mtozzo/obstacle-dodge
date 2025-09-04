using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class Mover : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;

    private InputAction moveAction;
    private Rigidbody rb;
    private Vector2 moveInput;

    private void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        rb = GetComponent<Rigidbody>();
        rb.interpolation = RigidbodyInterpolation.Interpolate;
        rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
        rb.freezeRotation = true;
    }

    private void Update()
    {
        moveInput = moveAction.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y);
        rb.linearVelocity = move * moveSpeed;
    }
}