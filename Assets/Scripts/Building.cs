using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building : MonoBehaviour
{
    [SerializeField] public List<GameObject> partBuildingList;
    [SerializeField] public List<GameObject> awakeBuildingList;
    [SerializeField] public Text helpBuy; 

    public void Start()
    {
        foreach (GameObject game in awakeBuildingList)
            game.SetActive(true);
    }

    public void Buy()
    {
        if (partBuildingList.Count != 0)
        {
            Resoucres.grant--;
            partBuildingList[0].SetActive(true);
            awakeBuildingList.Add(partBuildingList[0]);
            partBuildingList.RemoveAt(0);
        }
    }
}
    