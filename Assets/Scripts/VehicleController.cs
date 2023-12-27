using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class VehicleController : MonoBehaviour
{
    public NavMeshAgent agent;

    public GameObject path;
    private Transform[] pathPoints;

    public int index = 0;
    public float minDistance = 10f;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        pathPoints = new Transform[path.transform.childCount];
        for (int i = 0; i < pathPoints.Length; i++)
        {
            pathPoints[i] = path.transform.GetChild(i);
        }
    }

    private void Update()
    {
        Roam();
    }

    void Roam()
    {
        if (Vector3.Distance(transform.position, pathPoints[index].position) < minDistance)
        {
            if (index >= 0 && index < pathPoints.Length - 1)
            {
                index++;
            }
            else
            {
                index = 0;
            }
        }
        
        agent.SetDestination(pathPoints[index].position);
    }
}
