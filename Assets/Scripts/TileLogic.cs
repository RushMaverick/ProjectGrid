using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileLogic : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable";
    //[SerializeField] private string unitTag = "Unit";
    [SerializeField] GameObject GridController;
    [SerializeField] Transform _target;
    [SerializeField] GameObject targetUnit;

    public GameObject unit;

    private void Awake() {
    
    }

    private void Start() {
        _target = null;
    }

    private void Update() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //Sets a ray with the mouse as an input. 
        RaycastHit hit;

        if (_target != null){ //Sets color to default and resets target to null(in case it is assigned at the start.).
            var targetRenderer = _target.GetComponent<Renderer>();
            targetRenderer.material.color = Color.white;
            _target = null;
        }

        if (Physics.Raycast(ray, out hit)) { // Detects colliders if anything is between the camera and the mouse. 
            var target = hit.transform;

            if (target.CompareTag(selectableTag)){ //Checks if the target currently is set with the "Selectable" tag.

                var targetRenderer = target.GetComponent<Renderer>();

                if (targetRenderer != null){ //Logic for when something is within the raycast.
                    targetRenderer.material.color = Color.red;
                    _target = target;

                    if (Input.GetKeyDown("mouse 0") && _target.GetComponent<CollisionDetector>().isColliding){
                        Debug.Log("I am now selected.");
                         _target.GetComponent<CollisionDetector>().isColliding = false;
                    }
                }
            }
        }
    }
}