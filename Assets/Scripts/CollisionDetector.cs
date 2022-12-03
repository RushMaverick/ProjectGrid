using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    [SerializeField] private string unitTag = "Unit";

    public bool isColliding;
    
    GameObject thisUnit;
    GameObject gameController;

    void Update()
    {

    }

    private void OnMouseOver() {
        if (this.isColliding && Input.GetMouseButtonDown(0)){
            Debug.Log(this.gameObject.name);
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
