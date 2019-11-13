using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resoucres : MonoBehaviour
{

    [SerializeField] public static int grant;
    [SerializeField] private Text grantValue; 
    void Start()
    {
        grant = 2; 
    }

    private void Update()
    {
        grantValue.text = grant.ToString();
    }



}
