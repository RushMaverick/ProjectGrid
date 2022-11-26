using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    [SerializeField] private string unitTag = "Unit";

    public bool isColliding;
    
    GameObject thisUnit;

    void Update()
    {
        if (this.isColliding && Input.GetMouseButtonDown(0)){
            thisUnit.GetComponent<UnitLogic>().SelectedLogic(this);
        }   
    }

    public void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == unitTag){
            isColliding = true;
            thisUnit = other.gameObject;
            thisUnit.GetComponent<UnitLogic>().currentTile = this;
        }
    }
}
