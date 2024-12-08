using UnityEngine;

public class Triggerzone : MonoBehaviour
{
    public DoorController door; // Reference to the door controller script
    public DoorController2 door2; // Reference to the door controller script

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("8ball")) // Ensure the collider belongs to the ball
        {
            door.MoveToTargetPosition(); 
        }
        if (other.CompareTag("ball")) // Ensure the collider belongs to the ball
        {
            door2.MoveToTargetPositionX();
        }
    }
}
