using UnityEngine;

public class DeleteAfterTime : MonoBehaviour
{
    public float timeToLive = 20.0f; // Time in seconds before the object is deleted

    void Start()
    {
        // Schedule the object for deletion after the specified time
        Invoke("DeleteObject", timeToLive);
    }

    void DeleteObject()
    {
        // Remove the GameObject from the scene
        Destroy(gameObject);
    }
}


