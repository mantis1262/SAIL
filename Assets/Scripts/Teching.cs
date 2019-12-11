using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teching : MonoBehaviour
{

    [SerializeField] List<GameObject> studentsList;
    [SerializeField] public Sprite schoolNPCSNeedHelpSrite;
    public bool startHelpping = false;


    public void Rutine()
    {

        StartCoroutine("randomHelp");
    }

     public IEnumerator randomHelp()    
    {
        do
        {

            int randomI = Random.Range(0, studentsList.Count);
            studentsList[randomI].GetComponent<Student>().needHelp = true;
            studentsList[randomI].GetComponentInChildren<SpriteRenderer>().sprite = schoolNPCSNeedHelpSrite;
            yield return new WaitForSeconds(3);

        } while (startHelpping);
    }
}
