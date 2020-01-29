using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;


public class SchoolBrief : MonoBehaviour
{
    [SerializeField] public List<string> dzialania;
    [SerializeField] public List<float> wyniki;
    [SerializeField] public Text textDzilania;
    [SerializeField] Text Value;
    public int randomi = 0;
    public Student stunent;

    public void CheckValue()
    {

        if (float.Parse(Value.text.Trim('\r', ' '), CultureInfo.InvariantCulture) == wyniki[randomi])
        {
            GameObject.Find("Resoucers").GetComponent<Resoucres>().schoolBrief.gameObject.SetActive(false);
            MouseLook.SetCursorLock(true);
            dzialania.RemoveAt(randomi);
            wyniki.RemoveAt(randomi);
            stunent.needHelp = false;
            stunent.GetComponentInChildren<SpriteRenderer>().sprite = null;
        }
    }

    public void SetBrief(Student student)
    {
        MouseLook.SetCursorLock(false);
        gameObject.SetActive(true);
        randomi = Random.Range(0, wyniki.Count);
        this.stunent = student;
        textDzilania.text = dzialania[randomi].ToString();
    }
}
