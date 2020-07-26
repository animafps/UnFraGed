using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Settings : MonoBehaviour
{
    public TMP_InputField sensInputBox;
    public TMP_Text placeholder;
    float rfloat;
    string rstring;

    void Start()
    {
        rfloat = PlayerPrefs.GetFloat("Sensitivity");
        rstring = rfloat.ToString("F2");
        sensInputBox.text = rstring;

    }

    public void sensChange ()
    {
        if(sensInputBox.text != "")
        {
            PlayerPrefs.SetFloat("Sensitivity", float.Parse(sensInputBox.text));
        }
    }
}
