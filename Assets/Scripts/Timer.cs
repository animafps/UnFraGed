using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public Text timerText;
    bool started = false;
    private float timeStart;
    
    void start ()
    {

    }
    void Update () {
        if(!started)
            return;
        else if(started){
            timeStart += Time.deltaTime;
            timerText.text = timeStart.ToString("F2");
        }
    }

    public void Finish()
    {
        started = false;
    }
    public void Start()
    {
        started = true;
    }
}
