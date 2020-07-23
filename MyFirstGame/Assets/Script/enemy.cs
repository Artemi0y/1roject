using UnityEngine;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;

public class enemy : MonoBehaviour
{
    public List<Transform> waypoints;
    public Transform player;
    public int index;
    public float speed;
    void Update()
    {
        if (Vector3.Distance(player.position, transform.position) < 15)
        {

            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }


        if (Vector3.Distance(waypoints[index].position, transform.position) > 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[index].position, speed * Time.deltaTime);
        }
        else if (Vector3.Distance(waypoints[index].position, transform.position) < 1)
        {
           index++;
            if(index >= waypoints.Count)
            {
                index = 0;
            }
        }
       
       // transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
       //Debug.Log(Time.deltaTime);


    }
}
