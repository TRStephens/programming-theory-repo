using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Inheritance
public class Cube : Shapes
{
    // Encapsulation
    public string shapeName { get; private set; }
    [SerializeField] private TextMeshProUGUI textObject;
    // Start is called before the first frame update
    void Start()
    {
        SetName();
    }

    private void SetName()
    {
        shapeName = "Cube";
    }

    // Polymorphism
    public override void DisplayText()
    {
        textObject.text = shapeName;
    }
}
