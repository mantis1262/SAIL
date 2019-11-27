using System.Collections;
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
        door.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        //door.SetActive(true);
    }
}
