using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayMenu : MonoBehaviour
{
    public TMP_Text level1Time;
    float m_time;

    void Start()
    {
        SetText();
    }

    void Update()
    {
        level1Time.text = "Fastest Time: " + m_time.ToString("F2");
    }

    public void PlayGame ()
    {
        SceneManager.LoadScene("SampleScene");
    }

    void SetText()
    {
        m_time = PlayerPrefs.GetFloat("Time In Seconds:", 0);
    }
}
