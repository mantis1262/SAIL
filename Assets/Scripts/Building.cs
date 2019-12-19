using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building : MonoBehaviour
{
    [SerializeField] public List<GameObject> awakeBuildingList;
    [SerializeField] public Text helpBuy; 

    public void Start()
    {
        foreach (GameObject game in awakeBuildingList)
            game.SetActive(true);
    }

    public void Buy(GameObject part)
    {
            part.SetActive(true);
            awakeBuildingList.Add(part);
    }
}
    