using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("_Player").SendMessage("Finish");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    
    public void NextLevel()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Next Level");
    }

}
