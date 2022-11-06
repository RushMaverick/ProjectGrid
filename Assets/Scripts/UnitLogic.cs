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
        renderer.material.color = Color.red;
        isSelected = true;
    }
}
