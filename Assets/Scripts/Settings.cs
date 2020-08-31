using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public TMP_InputField sensInputBox;
    public TMP_Text placeholder;
    float rfloat;
    string rstring;
    int queuedframes;
    int antialiasing;
    string shadows;
    int maxframerate;
    public TMP_InputField fpsInputBox;

    void Start()
    {
        rfloat = PlayerPrefs.GetFloat("Sensitivity", 30);
        rstring = rfloat.ToString("F2");
        sensInputBox.text = rstring;
        queuedframes = PlayerPrefs.GetInt("MaxQueuedFrames", 2);
        antialiasing = PlayerPrefs.GetInt("AntiAliasing", 2);
        shadows = PlayerPrefs.GetString("Shadows", "ShadowQuality.All");
        vsync = PlayerPrefs.GetInt("vSync", 0);
        maxframerate = PlayerPrefs.GetInt("maxFrameRate", -1);
    }

    public void apply()
    {
        QualitySettings.maxQueuedFrames = queuedframes;
        QualitySettings.shadows = shadows;
        Application.targetFrameRate = maxframerate;
        QualitySettings.vSyncCount = vysnc;
        QualitySettings.antiAliasing = antialiasing;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void sensChange ()
    {
        if(sensInputBox.text != "")
        {
            PlayerPrefs.SetFloat("Sensitivity", float.Parse(sensInputBox.text));
        }
    }
    
    public void buffering ()
    {
        
    }

    public void antiAliasing ()
    {

    }

    public void shadows ()
    {

    }

    public void vSync ()
    {

    }

    public void maxFrameRate ()
    {
        if(fpsInputBox.text != " ")
        {
            PlayerPrefs.SetInt("maxFrameRate", fpsInputBox.text)
        }
    }
}
