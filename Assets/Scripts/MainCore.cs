using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCore : MonoBehaviour
{
    public Material matSelected;
    public Material matUnselected;
    private GameObject currentSelectedObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if(currentSelectedObject != null)
                {
                    MeshRenderer mrOld = currentSelectedObject.GetComponent<MeshRenderer>();
                    if (mrOld != null)
                    {
                        mrOld.material = matUnselected;
                    }
                }

                currentSelectedObject = hit.transform.gameObject;
                MeshRenderer mr = currentSelectedObject.GetComponent<MeshRenderer>();

                if (mr != null)
                {
                    mr.material = matSelected;
                }
            }
        }
    }
}
