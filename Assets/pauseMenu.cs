using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public GameObject IngameOverlay;
    public GameObject PauseOverlay;

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown("escape")) && (GetComponent<CPMPlayer> ().enabled)) 
        {
            GameObject.Find("_Player").SendMessage("Pause");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            IngameOverlay.SetActive(false);
            PauseOverlay.SetActive(true);
            GetComponent<CPMPlayer> ().enabled = false;
        }
        else if (Input.GetKeyDown("escape"))
        {
            exitMenu();
        }
    }

    public void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void exitMenu()
    {
        GameObject.Find("_Player").SendMessage("Begin");
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        IngameOverlay.SetActive(true);
        PauseOverlay.SetActive(false);
        GetComponent<CPMPlayer> ().enabled = true;  
    }

    public void toMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
