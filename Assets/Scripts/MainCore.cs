using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCore : MonoBehaviour
{
    public Material matSelected;
    public Material matUnselected;
    private GameObject currentSelectedObject;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {   // Mouse button "0" clicked

            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f, LayerMask.GetMask("Building","Unit"))) {  // Ray got hit to a building or a unit

                if(currentSelectedObject != null) { // There is already a selected object

                    MeshRenderer mrOld = currentSelectedObject.GetComponent<MeshRenderer>();

                    if (mrOld != null) { // Current selected object has a meshrenderer
                        mrOld.material = matUnselected; // Change material to unselected
                    }

                }

                currentSelectedObject = hit.transform.gameObject; // Get the recently selected object
                MeshRenderer mr = currentSelectedObject.GetComponent<MeshRenderer>(); 

                if (mr != null) { // Recently selected object has a meshrenderer
                    mr.material = matSelected; // Change material to selected
                }

            }

            else {  // Ray did not hit to a building or a unit
                
                if (currentSelectedObject != null) { // There is already a selected object 

                    MeshRenderer mrOld = currentSelectedObject.GetComponent<MeshRenderer>();

                    if (mrOld != null) { // Current selected object has a meshrenderer
                        mrOld.material = matUnselected; // Change material to unselected
                    }

                    currentSelectedObject = null;
                }
            }

        }
    }
}
