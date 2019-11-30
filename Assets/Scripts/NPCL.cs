using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCL : MonoBehaviour
{
    [SerializeField] public bool isFollow;
    [SerializeField] public Transform player;
    void Start()
    {
        isFollow = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isFollow)
        {
            this.GetComponent<Rigidbody>().velocity = player.position - transform.position; 
        }
    }
}
