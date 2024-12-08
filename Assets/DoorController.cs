using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Vector3 originalPosition; // Store the original position
    public float targetZPosition = 5.61000013f; // Target z position
    public float moveSpeed = 2f; // Speed of movement

    void Start()
    {
        // Store the original position
        originalPosition = transform.position;
    }

    public void MoveToTargetPosition()
    {
        StopAllCoroutines(); // Stop any ongoing movement
        StartCoroutine(MoveDoorZ(targetZPosition));
    }

    public void ResetToOriginalPosition()
    {
        StopAllCoroutines();
        StartCoroutine(MoveDoorZ(originalPosition.z));
    }

    private System.Collections.IEnumerator MoveDoorZ(float targetZ)
    {
        // Keep x and y fixed, only change z
        Vector3 startPosition = transform.position;
        Vector3 targetPosition = new Vector3(startPosition.x, startPosition.y, targetZ);

        while (Vector3.Distance(transform.position, targetPosition) > 0.01f)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * moveSpeed);
            yield return null;
        }

        transform.position = targetPosition; // Snap to final position
    }
}
