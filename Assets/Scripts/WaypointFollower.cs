using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;
    int currentWaypointtIndex = 0;

    [SerializeField] float speed = 1f;

    void Update()
    {
        if (waypoints.Length == 0)
        {
            return;
        }

        if (Vector3.Distance(transform.position, waypoints[currentWaypointtIndex].transform.position) < .1f)
        {
            currentWaypointtIndex++;

            if (currentWaypointtIndex >= waypoints.Length)
            {
                currentWaypointtIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointtIndex].transform.position, speed * Time.deltaTime);
    }
}
