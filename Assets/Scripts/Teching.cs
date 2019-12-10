using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teching : MonoBehaviour
{

    [SerializeField] List<GameObject> studentsList;
    public bool startHelpping = false;


    void Update()
    {
        if (startHelpping)
        {
            StartCoroutine("randomHelp");
        }
    }

     public IEnumerator randomHelp()
    {
        int randomI = Random.Range(0, studentsList.Count - 1);
        studentsList[randomI].GetComponent<Student>().needHelp = true;
        yield return new WaitForSeconds(1);
    }
}
