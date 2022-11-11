using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitLogic : MonoBehaviour
{
    public Renderer renderer;
    bool isSelected;
    void Start()
    {
        renderer = GetComponent<Renderer>();
        isSelected = false;
    }

    void Update()
    {
        
    }

    void MovementLogic(){
        Debug.Log("Unit is now selected.");
        renderer.material.color = Color.red;
        isSelected = true;
    }
}
