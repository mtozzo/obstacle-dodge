using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int score = 0;
    
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("You've bumped into a thing " + ++score + " times!");
    }
}
