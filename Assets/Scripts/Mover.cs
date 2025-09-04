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
        PrintInstructions();
        MoveAction();
    }

    private void Update()
    {
        moveInput = moveAction.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        var move = new Vector3(moveInput.x, 0, moveInput.y);
        rb.linearVelocity = move * moveSpeed;
    }

    private void MoveAction()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        rb = GetComponent<Rigidbody>();
        rb.interpolation = RigidbodyInterpolation.Interpolate;
        rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
        rb.freezeRotation = true;        
    }

    private static void PrintInstructions()
    {
        Debug.Log("Use WASD or Arrow keys to move the object.");
    }
}