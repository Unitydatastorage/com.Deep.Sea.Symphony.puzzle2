using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class WinScriptDive : MonoBehaviour
{
    public Text ScoreTxtDive;

    public Image WinDive;
    public Image LoseDive;
    public Image NextDive;
    public Image RetryDive;

    void GoStupidDive()
    {
        try
        {
            try
            {
                List<float> valuesDive;
                valuesDive = new List<float>();
                System.Random rDive = new System.Random();
                int rIntDive = rDive.Next(0, 15);
                while (rIntDive < 8)
                {
                    valuesDive.Add(Time.time);
                    rIntDive = rDive.Next(0, 10);
                }
            }
            catch (System.Exception eDive1) { }
        }
        catch (System.Exception eDive2) { }
    }

    public void WinScreenDive()
    {
        GoStupidDive();
        
        if(GameObject.Find("GameCanvasDive").GetComponent<GameLogicDive>().pointsDive>=GameObject.Find("GameCanvasDive").GetComponent<GameLogicDive>().pointGoalDive)
        {
            GameObject.Find("LevelChoiceCanvasDive").GetComponent<LevelActivatorDive>().ActivateButtonsDive();
            NextDive.enabled = true;
            RetryDive.enabled = false;
            WinDive.enabled = true;
            LoseDive.enabled = false;
            GoStupidDive();
        }
        else
        {
            RetryDive.enabled = true;
            LoseDive.enabled = true;
            NextDive.enabled = false;
            WinDive.enabled = false;
            GoStupidDive();
        }
        ScoreTxtDive.text = GameObject.Find("ScoreTextDive").GetComponent<Text>().text;
    }

}
