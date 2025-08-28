using System;
using UnityEngine;
using UnityEngine.InputSystem; 

public class Mover : MonoBehaviour
{
    [SerializeField] public float xSpeed = 0.1f;
    [SerializeField] public float ySpeed = 0.1f;
    [SerializeField] public float zSpeed = 0.1f;
    
    InputAction moveAction;
    InputAction jumpAction;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");    
    }

    // Update is called once per frame
    private void Update()
    {
        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        
        // transform.Translate(xSpeed * Time.deltaTime, ySpeed * Time.deltaTime, zSpeed * Time.deltaTime);
        transform.Translate(moveValue.x * xSpeed * Time.deltaTime, 0, moveValue.y * zSpeed * Time.deltaTime);
        Debug.Log(moveValue);
        
        if (jumpAction.IsPressed())
        {
            transform.Translate(0, ySpeed * Time.deltaTime, 0);
            Debug.Log("Jump is pressed!");
        }        
    }
}
