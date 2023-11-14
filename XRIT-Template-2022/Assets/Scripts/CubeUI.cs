using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CubeUI : MonoBehaviour
{
    public GameObject cube;

    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        Button buttonRed = root.Q<Button>("ButtonRed");
        Button buttonBlue = root.Q<Button>("ButtonBlue");
        Button buttonRandom = root.Q<Button>("ButtonRandom");

        buttonRandom.clicked += cube.GetComponent<ColorRandomizer>().ChangeMaterialColor;
    }
}
