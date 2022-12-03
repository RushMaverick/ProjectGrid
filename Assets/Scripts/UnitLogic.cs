using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitLogic : MonoBehaviour
{
    public CollisionDetector currentTile;
    public Renderer renderer;
    public ClickLevel isSelected;

    public enum ClickLevel: int{
        UNCLICKED, 
        CLICKED,
        DOUBLECLICKED
    }

    void Start()
    {
        renderer = GetComponent<Renderer>();
        isSelected = ClickLevel.UNCLICKED;
    }

    public void SelectedLogic(CollisionDetector tile){
        //Waits for the next clicked point and sets it's transform to that point.
        if (currentTile == tile)
        {
            if (isSelected == ClickLevel.UNCLICKED){
                Debug.Log(isSelected);
                isSelected = ClickLevel.CLICKED;
            }
            else if (isSelected == ClickLevel.CLICKED){
                Debug.Log(isSelected);
                isSelected = ClickLevel.DOUBLECLICKED;
            }
            else if (isSelected == ClickLevel.DOUBLECLICKED){
                Debug.Log(isSelected);
                isSelected = ClickLevel.UNCLICKED;
            }
        }
    }
}
