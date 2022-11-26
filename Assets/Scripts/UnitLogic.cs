using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitLogic : MonoBehaviour
{
    public CollisionDetector currentTile;
    public Renderer renderer;
    public int isSelected;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        isSelected = 0;
    }

    public void SelectedLogic(CollisionDetector tile){
        //Waits for the next clicked point and sets it's transform to that point.
        if (currentTile == tile)
        {
            if (isSelected == 1)
            {
                Debug.Log("The value is now: " + isSelected);
                isSelected++;
            }
            if (isSelected == 0)
            {
                Debug.Log("The value is now: " + isSelected);
                isSelected++;
            }
            if (isSelected == 2)
            {
                Debug.Log("The value is now: " + isSelected);
                isSelected--;
                isSelected--;
            }
        }
    }
}
