using UnityEngine;

public class Balon : MonoBehaviour
{
    public float speed = 5f;     
    public float leftBoundary = -2f; 
    public float rightBoundary = 2f; 

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);

        Vector3 newPosition = transform.position + movement;

        newPosition.x = Mathf.Clamp(newPosition.x, leftBoundary, rightBoundary);

        transform.position = newPosition;
    }
}
