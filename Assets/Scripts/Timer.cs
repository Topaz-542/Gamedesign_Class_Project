using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeStart;
    public TextMeshProUGUI timer;

    bool timerActive = true;

    void Start()
    {
        timer.text = timeStart.ToString("F2");

    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive)
        {
            timeStart += Time.deltaTime;
            timer.text = timeStart.ToString("F2");
            if(timeStart >= 999.99)
            {
                timer.text = "999.99";
            }
        }
    }
}
