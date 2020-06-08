using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("_Player").SendMessage("Start");
    }
    
}