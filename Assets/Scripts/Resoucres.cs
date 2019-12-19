using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resoucres : MonoBehaviour
{

    [SerializeField] public static int grant;
    [SerializeField] public List<Sprite> labNPCStatusSpirtes;
    [SerializeField] public SchoolBrief schoolBrief;

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
        {
            textHelpper.gameObject.SetActive(true);
            textHelpper.text = "Posiadane szkło: " + glassValue;
            textHelpper.color = Color.green;
        }
        else if (paperValue != 0)
        {
            textHelpper.gameObject.SetActive(true);
            textHelpper.text = "Posiadany papier: " + paperValue;
            textHelpper.color = Color.blue;

        }
        else if (plasticValue != 0)
        {
            textHelpper.gameObject.SetActive(true);
            textHelpper.text = "Posiadany plastik: " + plasticValue;
            textHelpper.color = Color.yellow;


        }
        else
        {
            textHelpper.gameObject.SetActive(false);
            textHelpper.text = "";
        }
    }
    
}