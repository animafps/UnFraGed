using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    bool started = false;
    float timeStart;
    float m_time;
    public TMP_Text fastTime;
    public GameObject IngameOverlay;
    public GameObject FinishScreen;

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
        if((m_time >= timeStart) && (timeStart > 0))  
        {
            PlayerPrefs.SetFloat("Time In Seconds:", timeStart);
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
        m_time = PlayerPrefs.GetFloat("Time In Seconds:", 0);
    }

    public void Pause()
    {
        started = false;
    }
}
