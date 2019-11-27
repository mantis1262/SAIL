using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resoucres : MonoBehaviour
{

    [SerializeField] public static int grant;
    public static int glassValue;
    public static int paperValue;
    public static int plasticValue;
    [SerializeField] private Text grantValue;
    [SerializeField] private Text textHelpper;

    void Start()
    {
        grant = 2;
        glassValue = 0;
        paperValue = 0;
        plasticValue = 0;
    }

    private void Update()
    {
        grantValue.text = grant.ToString();
        if (glassValue != 0)
            textHelpper.text = "Posiadane szkło: " + glassValue;
        else if (paperValue != 0)
            textHelpper.text = "Posiadany papier: " + paperValue;
        else if (plasticValue != 0)
            textHelpper.text = "Posiadany plastic: " + plasticValue;
        else
            textHelpper.text = "";
    }
}