using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCL : MonoBehaviour
{
    [SerializeField] public bool isFollow;
    [SerializeField] public Transform player;
    [SerializeField] public NavMeshAgent navMesh;
    void Start()
    {
        isFollow = false;
        navMesh = this.transform.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isFollow)
        {
            navMesh.SetDestination(player.position);
          //  this.GetComponent<Rigidbody>().velocity = player.position - transform.position; 
        }
        else
            navMesh.SetDestination(this.transform.position);

    }
}
