using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public string sensitivityInput;

    public void SetSens ()
    {
        float Sens = float.Parse(sensitivityInput);
        Debug.Log(Sens);
    }
}
