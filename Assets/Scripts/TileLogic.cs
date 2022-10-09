using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileLogic : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable";
    [SerializeField] private string unitTag = "Unit";

    private Transform _target;

    void Start() {
    }

    private void Update() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //Sets a ray with the mouse as an input. 
        RaycastHit hit;

        if (_target != null){ //Sets color to default and resets target to null.
            var targetRenderer = _target.GetComponent<Renderer>();
            targetRenderer.material.color = Color.white;
            _target = null;
        }

        if (Physics.Raycast(ray, out hit)) { // Detects colliders if anything is between the camera and the mouse. 
            var target = hit.transform;

            if (target.CompareTag(selectableTag)){ //Checks if the target currently is with the "Selectable" tag.
                var targetRenderer = target.GetComponent<Renderer>();
                if (targetRenderer != null){ //Logic for when something is within the raycast.
                    if (Input.GetKeyDown("mouse 0")){
                        Debug.Log(target);
                    }
                    targetRenderer.material.color = Color.red;
                    _target = target;
                }
            }
        }
    }
     
    //Color tile that is selected. 
    //Select object with raycasting.
    //Return info on object. 
}
