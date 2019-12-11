using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;


public class SchoolBrief : MonoBehaviour
{
    [SerializeField] List<string> dzialania; 
    [SerializeField] public List<float> wyniki;
    [SerializeField] Text textDzilania;
    [SerializeField] Text Value;
    public int randomi = 0;

    public void Update()
    {
        textDzilania.text = dzialania[randomi];
    }

    public void CheckValue()
    {
        if (float.Parse(Value.text) == wyniki[randomi])
        {
            GameObject.Find("Resoucers").GetComponent<Resoucres>().schoolBrief.gameObject.SetActive(false);
            MouseLook.SetCursorLock(false);
        }
    }
}
