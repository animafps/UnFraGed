using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayMenu : MonoBehaviour
{
    public TMP_Text level1Time;
    float level1;

    void Start()
    {
        SetText();
    }

    void Update()
    {
        level1Time.text = "Fastest Time: " + level1.ToString("F2");
    }

    public void PlayGame ()
    {
        SceneManager.LoadScene("SampleScene");
    }

    void SetText()
    {
        level1 = PlayerPrefs.GetFloat("Level 1", 0);
    }
}
