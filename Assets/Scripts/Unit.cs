using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Unit : MonoBehaviour
{
    private NavMeshAgent agent;
    public float health;
    public float damage;

    public 

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        
    }

    public void Walk(Vector3 goal)
    {
        agent.SetDestination(goal);
    }

    public void SetAgent(){

        agent = GetComponent<NavMeshAgent>();

    }

    public void GoToBuilding(Building b)
    {

    }

}
