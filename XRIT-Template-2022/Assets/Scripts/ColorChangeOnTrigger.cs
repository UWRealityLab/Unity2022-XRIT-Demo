using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeOnTrigger : MonoBehaviour
{
    private Color originalColor;
    private Renderer objectRenderer;
    private Vector3 originalPosition;

    public float moveDistance = 2.0f; // Set the distance the object moves in the Inspector
    public float moveSpeed = 2.0f;    // Set the speed of the back and forth movement

    private bool isMovingRight = true;

    void Start()
    {
        // Store the original color when the script starts
        objectRenderer = GetComponent<Renderer>();
        if (objectRenderer != null)
        {
            originalColor = objectRenderer.material.color;
        }

        originalPosition = transform.position;
    }

    void Update()
    {
        // Move the object back and forth on the x-axis
        MoveBackAndForth();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the entering collider has a specific tag or layer if needed
        // For example, you might want to change color only when colliding with objects tagged as "Player"
        // if (!other.CompareTag("Player")) return;
        Debug.Log("entered trigger");
        // Change the color to red
        if (objectRenderer != null)
        {
            Debug.Log("entered trigger");
            objectRenderer.material.color = Color.red;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the exiting collider has a specific tag or layer if needed
        // For example, you might want to change color back only when exiting objects tagged as "Player"
        // if (!other.CompareTag("Player")) return;

        // Revert to the original color
        if (objectRenderer != null)
        {
            objectRenderer.material.color = originalColor;
        }
    }

    private void MoveBackAndForth()
    {
        if (isMovingRight)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

            if (transform.position.x >= originalPosition.x + moveDistance)
            {
                isMovingRight = false;
            }
        }
        else
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

            if (transform.position.x <= originalPosition.x - moveDistance)
            {
                isMovingRight = true;
            }
        }
    }
}





