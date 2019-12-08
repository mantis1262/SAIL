using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SchoolBrief : MonoBehaviour
{
    [SerializeField] List<string> dzialania; 
    [SerializeField] List<float> wyniki;
    [SerializeField] Text textDzilania;
    [SerializeField] Text Value;
    private int randomi;

    private void Start()
    {
        randomi = Random.Range(0, wyniki.Count - 1);
    }

    public void Update()
    {
        textDzilania.text = dzialania[randomi];
    }

    public void CheckValue()
    {
       Debug.Log(float.Parse(Value.text));
       Debug.Log(float.Parse(Value.text) == wyniki[randomi]);
    }
}
