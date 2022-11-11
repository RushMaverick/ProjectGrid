using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    [SerializeField] private string unitTag = "Unit";

    public bool isColliding;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == unitTag){
            isColliding = true;
            //Send info to UnitLogic script.
        }
    }
}
