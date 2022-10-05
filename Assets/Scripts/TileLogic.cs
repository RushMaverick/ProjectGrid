using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileLogic : MonoBehaviour
{
    private Renderer renderer;
    public Camera cam;
    
    void Start() {
        renderer = GetComponent<Renderer>();
    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) { //When Mouse Button 0 is pressed a Ray is shot from the camera towards the point the mouse point to. 
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hitInfo)) {
                Debug.Log(hitInfo.collider.gameObject.GetComponent<Rigidbody>());
            }
        }
    }

    private void OnMouseEnter() {
        renderer.material.color = Color.red;
    }

    private void OnMouseExit() {
        renderer.material.color = Color.white;
    }
     
    //Color tile that is selected. 
    //Select object with raycasting.
    //Return info on object. 
}
