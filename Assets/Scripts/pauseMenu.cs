using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public GameObject IngameOverlay;
    public GameObject PauseOverlay;
    public GameObject OptionsOverlay;
    public Timer timer;
    bool didstart;

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown("escape")) && (GetComponent<CPMPlayer>().enabled))
        {
            if (timer.started)
            {
                GameObject.Find("_Player").SendMessage("Pause");
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                IngameOverlay.SetActive(false);
                PauseOverlay.SetActive(true);
                GetComponent<CPMPlayer>().enabled = false;
                didstart = true;
            }
            else
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                IngameOverlay.SetActive(false);
                PauseOverlay.SetActive(true);
                GetComponent<CPMPlayer>().enabled = false;
                didstart = false;
            }
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
        if (didstart)
        {
            GameObject.Find("_Player").SendMessage("Begin");
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            IngameOverlay.SetActive(true);
            PauseOverlay.SetActive(false);
            OptionsOverlay.SetActive(false);
            GetComponent<CPMPlayer>().enabled = true;
        }
        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            IngameOverlay.SetActive(true);
            PauseOverlay.SetActive(false);
            OptionsOverlay.SetActive(false);
            GetComponent<CPMPlayer>().enabled = true;
        }
    }

    public void toMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
