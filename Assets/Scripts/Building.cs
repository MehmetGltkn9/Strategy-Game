using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public GameObject unitPrefab;
    private float timer;
    public GameObject createPoint;
    public GameObject arrivePoint;

    // Start is called before the first frame update
    void Start()
    {
        timer = 2f;
    }

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;
        if (timer <= 0){

            GameObject newUnit = Instantiate(unitPrefab, createPoint.transform.position, Quaternion.identity);
            Unit u = newUnit.GetComponent<Unit>();

            u.SetAgent();
            u.Walk(arrivePoint.transform.position);
            
            timer = 2f;

        }

    }

    internal void SetArrivePoint(Vector3 point)
    {
        arrivePoint.transform.SetPositionAndRotation(point, Quaternion.identity);
    }
}
