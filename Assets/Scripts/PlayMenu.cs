using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayMenu : MonoBehaviour
{
    public TMP_Text level1Time;
    float level1;
    public TMP_Text level2Time;
    float level2;

    void Start()
    {
        SetText();
    }

    void Update()
    {
        level1Time.text = "Fastest Time: " + level1.ToString("F2");
        level2Time.text = "Fastest Time: " + level2.ToString("F2");
    }

    public void PlayGame ()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }

    void SetText()
    {
        level1 = PlayerPrefs.GetFloat("Level 1", 0);
        level2 = PlayerPrefs.GetFloat("Level 2", 0);
    }
}
