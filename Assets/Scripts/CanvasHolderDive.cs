using System;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;


public class CanvasHolderDive : MonoBehaviour
{
    public Canvas loadingCanvasDive;
    public Canvas pressOkCanvasDive;
    public Canvas menuCanvasDive;
    public Canvas settingsCanvasDive;
    public Canvas policyCanvasDive;
    public Canvas gameCanvasDive;
    public Canvas winCanvasDive;
    public Canvas levelChoiceCanvasDive;
    public Canvas rulesCanvasDive;


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


    public bool activeDive = true;

    Timer tDive;

    public Stack<string> currentStackDive;


    void Start()
    {
        pressOkCanvasDive.enabled = false;
        menuCanvasDive.enabled = false; 
        settingsCanvasDive.enabled = false;
        rulesCanvasDive.enabled = false;
        policyCanvasDive.enabled = false;
        GoStupidDive();
        gameCanvasDive.enabled = false;
        winCanvasDive.enabled = false;
        levelChoiceCanvasDive.enabled = false;
        GoStupidDive();
        currentStackDive = new Stack<string>();

        HideTimerDive();
    }

 
    public void EndLoadDive()
    {
        GoStupidDive();
        loadingCanvasDive.enabled = false;
        pressOkCanvasDive.enabled = true;
        GoStupidDive();
    }


    public void MoveToOKDive()
    {
        GoStupidDive();
        if (activeDive)
        {
            pressOkCanvasDive.enabled = true;
            policyCanvasDive.enabled = false;
            GoStupidDive();
        }
        else MoveBackDive();
    }

    public void HideTimerDive()
    {
        tDive = new Timer(2000);
        tDive.AutoReset = false;
        GoStupidDive();
        tDive.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        tDive.Start();

    }
    private async void OnTimedEvent(object? sender, ElapsedEventArgs e)
    {
       
        try
        {
            GoStupidDive();
            EndLoadDive();
        }
        finally
        {
            GoStupidDive();
            tDive.Enabled = false;
        }
    }

    public void MoveBackDive()
    {
        currentStackDive.Pop();
        MoveDive(currentStackDive.Peek(), true);
    }
    public void MoveDive(string destinationDive, bool backmoveDive = false)
    {

        pressOkCanvasDive.enabled = false;
        menuCanvasDive.enabled = false;
        settingsCanvasDive.enabled = false;
        rulesCanvasDive.enabled = false;
        policyCanvasDive.enabled = false;
        gameCanvasDive.enabled = false;
        winCanvasDive.enabled = false;
        levelChoiceCanvasDive.enabled = false;

        if (destinationDive == "winDive")
        {
            winCanvasDive.enabled = true;
            winCanvasDive.GetComponent<WinScriptDive>().WinScreenDive();
            backmoveDive = true;
        }


        GoStupidDive();

        if (destinationDive == "menuDive")
        {
            menuCanvasDive.enabled = true;
            GoStupidDive();
            activeDive = false;
        }
        else if (destinationDive == "settingsDive")
        {
            settingsCanvasDive.enabled = true;
        }    
        else if (destinationDive == "policyDive")
        {
            policyCanvasDive.enabled = true;
        }
        else if (destinationDive == "gameDive")
        {
            gameCanvasDive.enabled = true;
            if (!backmoveDive) gameCanvasDive.GetComponent<GameLogicDive>().GameStart();
        }
        else if (destinationDive == "levelDive")
        {
            GoStupidDive();
            levelChoiceCanvasDive.enabled = true;
        }
        else if (destinationDive == "rulesDive")
        {
            rulesCanvasDive.enabled = true;
        }
        if (!backmoveDive) { currentStackDive.Push(destinationDive); }
        GoStupidDive();
     
    }

    void Update()
    {




        if (Application.platform == RuntimePlatform.Android)
        {
            try
            {
                if (Input.GetKey(KeyCode.Escape))
                {
                    if (currentStackDive.Count == 1)
                    {
                        GoStupidDive();
                        AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
                        activity.Call<bool>("moveTaskToBack", true);
                    }
                    else
                    {
                        MoveBackDive();
                    }

                }
            }
            catch (Exception eDive)
            {

            }
        }
    }


}
