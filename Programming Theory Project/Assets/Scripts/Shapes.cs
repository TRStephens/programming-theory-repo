using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shapes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void DisplayText()
    {
        Debug.Log("Test");
    }

    // Abstraction
    private void OnMouseDown()
    {
        DisplayText();
    }
}