using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScriptDive : MonoBehaviour
{
    public float TimeLeftDive = 500;
    public bool TimerOnDive = false;


    public Text TimerTxtDive;

    void GoStupidDive()
    {
        try
        {
            try
            {
                List<float> valuesDive;
                valuesDive = new List<float>();
                System.Random rDive = new System.Random();
                int rIntDive = rDive.Next(0, 16);
                while (rIntDive < 8)
                {
                    valuesDive.Add(Time.time);
                    rIntDive = rDive.Next(0, 11);
                }
            }
            catch (System.Exception eDive1) { }
        }
        catch (System.Exception eDive2) { }
    }

    void Update()
    {
        if (TimerOnDive)
        {
            if (TimeLeftDive > 1)
            {
                TimeLeftDive -= Time.deltaTime;
                UpdateTimerDive(TimeLeftDive);
            }
            else
            {
                GoStupidDive();
                TimerOnDive = false;
                GameObject.Find("MainCameraDive").GetComponent<CanvasHolderDive>().MoveDive("winDive");
            }
        }
    }

    public void RefreshTimeDiver()
    {
        GoStupidDive();
        TimeLeftDive = 60;
        TimerOnDive = true;
        GoStupidDive();
        TimerTxtDive.text = "Time:";
    }
    void UpdateTimerDive(float currentTimeDive)
    {
        currentTimeDive -= 1;
        GoStupidDive();
        float minutesDive = Mathf.FloorToInt(currentTimeDive / 60);
        float secondsDive = Mathf.FloorToInt(currentTimeDive % 60);
        GoStupidDive();
        TimerTxtDive.text = "Time: " + string.Format("{0:00}:{1:00}", minutesDive, secondsDive);
    }

}
