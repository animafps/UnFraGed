using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public Text timerText;
    bool started = false;
    private float timeStart;
    
    void start()
    {
        timerText.text = timeStart.ToString("F2");
    }
    // Update is called once per frame
    void Update()
    {
        if(started == true){
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
