using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PushableObject : MonoBehaviour
{
    public float pushForce = 5f; // The force applied when pushing the object

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collider belongs to the player
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("player hit");
            // Calculate the direction of the push
            Vector3 pushDirection = collision.transform.forward;

            // Apply the push force to the rigidbody
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(pushDirection * pushForce, ForceMode.Impulse);
        }
    }
}
