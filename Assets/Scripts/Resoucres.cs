using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resoucres : MonoBehaviour
{

    [SerializeField] public static int grant;
    [SerializeField] public List<Sprite> labNPCStatusSpirtes;
    [SerializeField] public List<GameObject> finalPoints;
    [SerializeField] public static List<GameObject> staticFinalPoints;
    [SerializeField] public SchoolBrief schoolBrief;

    public static int glassValue;
    public static int paperValue;
    public static int plasticValue;
    public static int correctAnserw;
    [SerializeField] private Text grantValue;
    [SerializeField] private Text textHelpper;


    void Start()
    {
        grant = 1;
        glassValue = 0;
        paperValue = 0;
        plasticValue = 0;
        correctAnserw = 0;
        staticFinalPoints = new List<GameObject>();
        staticFinalPoints.AddRange(finalPoints);
    }

    private void Update()
    {
        grantValue.text = grant.ToString();
    }

    public static void ChcekIfCollectAll()
    {
        if(paperValue == 1 && glassValue == 3 && plasticValue == 2)
        {
            grant++;
        }
    }

    public static void CheckEndPoint()
    {

        if (staticFinalPoints[0].GetComponent<Point>().door.gameObject.active == false &&
            staticFinalPoints[1].GetComponent<Point>().door.gameObject.active == false &&
            staticFinalPoints[2].GetComponent<Point>().door.gameObject.active == false)
        {
            foreach (GameObject gameObject in staticFinalPoints)
                Destroy(gameObject.GetComponent<Point>());
            Resoucres.grant++;
        }
    }
}