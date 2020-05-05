using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathbox : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        Application.LoadLevel(Application.loadedLevel); 
     }
}
