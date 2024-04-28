using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour
{
    [SerializeField]
    private float amount;
    public int type;
    public GameObject[] gatheringPoints;

    public bool[] availableGPs;

    // Start is called before the first frame update
    void Start()
    {
        availableGPs = new bool[gatheringPoints.Length];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool GatherResource()
    {

        for (int i = 0; i < availableGPs.Length; i++){

            if (!availableGPs[i]) {
                availableGPs[i] = true;
                return true;
            }

        }

        return false;

    }

}
