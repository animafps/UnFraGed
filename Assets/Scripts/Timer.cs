using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    public bool started = false;
    float timeStart;
    float m_time;
    public TMP_Text fastTime;
    public GameObject IngameOverlay;
    public GameObject FinishScreen;
    string levelNum;

    void Start()
    {
        SetText();
    }
    
    void Update () 
    {
        fastTime.text = "Fastest Time: " + m_time.ToString("F2");
        if(started)
        {
            timeStart += Time.deltaTime;
            timerText.text = timeStart.ToString("F2");
        }
    }

    public void Finish()
    {
        started = false;
        if((m_time >= timeStart) && (timeStart > 0) && (SceneManager.GetActiveScene ().buildIndex == 1)) 
        {
            PlayerPrefs.SetFloat("1", timeStart);
        }
        if ((m_time >= timeStart) && (timeStart > 0) && (SceneManager.GetActiveScene ().buildIndex == 2))
        {
            PlayerPrefs.SetFloat("2", timeStart);
        }
        IngameOverlay.SetActive(false);
        FinishScreen.SetActive(true);
        GetComponent<CPMPlayer> ().enabled = false;
    }

    public void Begin()
    {
        started = true;
    }

    void SetText()
    {
        if (SceneManager.GetActiveScene ().buildIndex == 1)
        {
            m_time = PlayerPrefs.GetFloat("1", 0);
        }
        else
        if (SceneManager.GetActiveScene ().buildIndex == 2)
        {
            m_time = PlayerPrefs.GetFloat("2", 0);
        }
    }

    public void Pause()
    {
        started = false;
    }
}
