using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCL : MonoBehaviour
{
    [SerializeField] public bool isFollow;
    [SerializeField] public Transform player;
    private NavMeshAgent navMesh;
    void Start()
    {
        isFollow = false;
        navMesh = this.transform.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if(isFollow)
        {
            navMesh.SetDestination(player.position);
        }
        else
            navMesh.SetDestination(this.transform.position);

    }
}
