using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathbox : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // When Player collides with the deathbox then restarts the level
    }
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Restart bind
        }
    }
}
