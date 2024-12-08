using UnityEngine;

public class DoorController2 : MonoBehaviour
{
    private Vector3 originalPosition; // Store the original position
    public float targetXPosition = 55f; // Target x position
    public float moveSpeed = 2f; // Speed of movement
    public GameObject text;
    void Start()
    {
        // Store the original position
        originalPosition = transform.position;
    }

    public void MoveToTargetPositionX()
    {
        StopAllCoroutines(); // Stop any ongoing movement
        StartCoroutine(MoveDoorX(targetXPosition));
        text.SetActive(true);
    }

    public void ResetToOriginalPosition()
    {
        StopAllCoroutines();
        StartCoroutine(MoveDoorX(originalPosition.x));
    }

    private System.Collections.IEnumerator MoveDoorX(float targetX)
    {
        // Keep y and z fixed, only change x
        Vector3 startPosition = transform.position;
        Vector3 targetPosition = new Vector3(targetX, startPosition.y, startPosition.z);

        while (Mathf.Abs(transform.position.x - targetPosition.x) > 0.01f) // Move until the x position is close enough
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * moveSpeed);
            yield return null;
        }

        transform.position = new Vector3(55f, transform.position.y, transform.position.z);
    }
}
