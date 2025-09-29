using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float rotationSpeedX = 10f;
    [SerializeField] private float rotationSpeedY = 10f;
    [SerializeField] private float rotationSpeedZ = 10f;
    
    void Update()
    {
        transform.Rotate(rotationSpeedX * Time.deltaTime, rotationSpeedY * Time.deltaTime, rotationSpeedZ * Time.deltaTime); // Rotate around the Y-axis
    }
}
