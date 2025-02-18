﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{

    [SerializeField] public GameObject door;    

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "NPCLCALL")
        {
            door.SetActive(false);
            Resoucres.CheckEndPoint();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag != "NPCLCALL")
            door.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag != "NPCLCALL")
            door.SetActive(true);
    }
}
