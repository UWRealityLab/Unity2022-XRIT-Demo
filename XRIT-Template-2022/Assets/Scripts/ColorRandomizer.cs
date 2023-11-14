using UnityEngine;

public class ColorRandomizer : MonoBehaviour
{
    void Start()
    {
        ChangeMaterialColor();
    }

    public void ChangeMaterialColor()
    {
        Renderer renderer = GetComponent<Renderer>();

        if (renderer != null)
        {
            // Generate a random color
            Color randomColor = new Color(Random.value, Random.value, Random.value);

            // Apply the random color to the material
            renderer.material.color = randomColor;
        }
        else
        {
            Debug.LogError("Renderer component not found on the object.");
        }
    }

    public void ChangeMaterialRed()
    {
        Renderer renderer = GetComponent<Renderer>();

        if (renderer != null)
        {
            // Apply the color red to the material
            renderer.material.color = new Color(1, 0, 0);
        }
        else
        {
            Debug.LogError("Renderer component not found on the object.");
        }
    }
    public void ChangeMaterialBlue()
    {
        Renderer renderer = GetComponent<Renderer>();

        if (renderer != null)
        {
            // Apply the color red to the material
            renderer.material.color = new Color(0, 0, 1);
        }
        else
        {
            Debug.LogError("Renderer component not found on the object.");
        }
    }

    public void ChangeMaterialToColor(Color c)
    {
        Renderer renderer = GetComponent<Renderer>();

        if (renderer != null)
        {
            // Apply the color red to the material
            renderer.material.color = c;
        }
        else
        {
            Debug.LogError("Renderer component not found on the object.");
        }
    }
}