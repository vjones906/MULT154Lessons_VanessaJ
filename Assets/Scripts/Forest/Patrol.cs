﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    public List<GameObject> waypoints;
    private NavMeshAgent agent;
    private const float WP_Threshold = 15.0f;
    private GameObject currentWP;
    private int currentWPIndex = -1;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        currentWP = GetNextWaypoint();
    }

    GameObject GetNextWaypoint()
    {
        currentWPIndex++;
        if (currentWPIndex == waypoints.Count)
        {
            currentWPIndex = 0;
        }
        return waypoints[currentWPIndex];
    }

    // Update is called once per frame
    public void PatrolWaypoints()
    {
        if(Vector3.Distance(transform.position, currentWP.transform.position) < WP_Threshold)
        {
            currentWP = GetNextWaypoint();
            agent.SetDestination(currentWP.transform.position);
        }
    }
}
