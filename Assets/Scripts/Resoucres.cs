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
        grant = 1;
        glassValue = 0;
        paperValue = 0;
        plasticValue = 0;
    }

    private void Update()
    {
        grantValue.text = grant.ToString();
    }
    
}