using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teching : MonoBehaviour
{

    [SerializeField] public List<GameObject> studentsList;
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

            if (Resoucres.correctAnserw == 5)
            {
                startHelpping = false;
                foreach(GameObject student in studentsList)
                {
                    student.GetComponent<Student>().needHelp = false;
                    student.GetComponentInChildren<SpriteRenderer>().sprite = null;
                }
                Resoucres.grant++;
            }

        } while (startHelpping);
    }
}
