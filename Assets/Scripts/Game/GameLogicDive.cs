using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

using UnityEngine;
using UnityEngine.UI;


public class GameLogicDive : MonoBehaviour
{

    public CellDive firstClickedDive;
    public bool boolFirstDive = false;

    public CellDive secondClickedDive;
    public bool boolSecondDive = false;
    System.Random rDive = new System.Random();
    public Text scoreTextDive;

    public Sprite sprite1Dive;
    public Sprite sprite2Dive;
    public Sprite sprite3Dive;
    public Sprite sprite4Dive;

    public Image cellDive11;
    public Image cellDive12;
    public Image cellDive13;
    public Image cellDive14;
    public Image cellDive15;

    public Image cellDive21;
    public Image cellDive22;
    public Image cellDive23;
    public Image cellDive24;
    public Image cellDive25;

    public Image cellDive31;
    public Image cellDive32;
    public Image cellDive33;
    public Image cellDive34;
    public Image cellDive35;

    public Image cellDive41;
    public Image cellDive42;
    public Image cellDive43;
    public Image cellDive44;
    public Image cellDive45;

    public Image cellDive51;
    public Image cellDive52;
    public Image cellDive53;
    public Image cellDive54;
    public Image cellDive55;

    public Image cellDive61;
    public Image cellDive62;
    public Image cellDive63;
    public Image cellDive64;
    public Image cellDive65;

    public bool firstMoveFinishedDive =false;
    public bool secondMoveFinishedDive = false;


    List<CellDive> cellsDive;
    bool destructionHappenedDive = false;

    public int pointsDive = 0;
    public int pointGoalDive = 50;
    public int pickedLevelDive = 0;
    bool pointCountDive = false;


    List<int> horizontal;
    List<int> vertical;


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

    public void TryCheck()
    {
        GoStupidDive();
        for (int jDive = 1; jDive < 31; jDive++)
        {

            if (horizontal.Contains(jDive)){
                
                if ((GameObject.Find("ButtonGameDive" + (jDive + 1).ToString()).GetComponent<CellDive>().spriteDive.GetInstanceID() == GameObject.Find("ButtonGameDive" + jDive.ToString()).GetComponent<CellDive>().spriteDive.GetInstanceID()) && (GameObject.Find("ButtonGameDive" + (jDive - 1).ToString()).GetComponent<CellDive>().spriteDive.GetInstanceID() == GameObject.Find("ButtonGameDive" + jDive.ToString()).GetComponent<CellDive>().spriteDive.GetInstanceID()))
                {
                    if (!GameObject.Find("ButtonGameDive" + (jDive - 1).ToString()).GetComponent<CellDive>().needsDestructionDive)
                    {
                        GameObject.Find("ButtonGameDive" + (jDive - 1).ToString()).GetComponent<CellDive>().needsDestructionDive = true;
                        if (pointCountDive)
                            pointsDive += 2;
                    }
                    if (!GameObject.Find("ButtonGameDive" + (jDive).ToString()).GetComponent<CellDive>().needsDestructionDive)
                    {
                        GameObject.Find("ButtonGameDive" + (jDive).ToString()).GetComponent<CellDive>().needsDestructionDive = true;
                        if (pointCountDive)
                            pointsDive += 2;
                    }
                    if (!GameObject.Find("ButtonGameDive" + (jDive + 1).ToString()).GetComponent<CellDive>().needsDestructionDive)
                    {
                        GameObject.Find("ButtonGameDive" + (jDive + 1).ToString()).GetComponent<CellDive>().needsDestructionDive = true;
                        if (pointCountDive)
                            pointsDive += 2;
                    }
                }
            }

            if (vertical.Contains(jDive))
            {
             
                if ((GameObject.Find("ButtonGameDive" + (jDive + 5).ToString()).GetComponent<CellDive>().spriteDive.GetInstanceID() == GameObject.Find("ButtonGameDive" + jDive.ToString()).GetComponent<CellDive>().spriteDive.GetInstanceID()) && (GameObject.Find("ButtonGameDive" + (jDive - 5).ToString()).GetComponent<CellDive>().spriteDive.GetInstanceID() == GameObject.Find("ButtonGameDive" + jDive.ToString()).GetComponent<CellDive>().spriteDive.GetInstanceID()))
                {
                    if (!GameObject.Find("ButtonGameDive" + (jDive - 5).ToString()).GetComponent<CellDive>().needsDestructionDive)
                    {
                        GameObject.Find("ButtonGameDive" + (jDive - 5).ToString()).GetComponent<CellDive>().needsDestructionDive = true;
                        if (pointCountDive)
                            pointsDive += 2;
                    }
                    if (!GameObject.Find("ButtonGameDive" + (jDive).ToString()).GetComponent<CellDive>().needsDestructionDive)
                    {
                        GameObject.Find("ButtonGameDive" + (jDive).ToString()).GetComponent<CellDive>().needsDestructionDive = true;
                        if (pointCountDive)
                            pointsDive += 2;
                    }
                    if (!GameObject.Find("ButtonGameDive" + (jDive + 5).ToString()).GetComponent<CellDive>().needsDestructionDive)
                    {
                        GameObject.Find("ButtonGameDive" + (jDive + 5).ToString()).GetComponent<CellDive>().needsDestructionDive = true;
                        if (pointCountDive)
                            pointsDive += 2;
                    }
                }
            }


        }
        GoStupidDive();
        bool happened = false;
        for (int jDive = 1; jDive < 31; jDive++)
        {
           if( GameObject.Find("ButtonGameDive" + jDive.ToString()).GetComponent<CellDive>().needsDestructionDive){
                GameObject.Find("ButtonGameDive" + jDive.ToString()).GetComponent<CellDive>().needsDestructionDive = false;
                NewDestroy(GameObject.Find("ButtonGameDive" + jDive.ToString()).GetComponent<CellDive>(), jDive);
                happened = true;
            }
        }

        if (happened) { destructionHappenedDive = true;
            if (pointCountDive) GameObject.Find("MainCameraDive").GetComponent<SoundManagerDive>().PlayPingDive();
            GoStupidDive();
        }
        else destructionHappenedDive= false;


        }


    public void NewDestroy(CellDive targetDive,int numberDive)
    {
        if (numberDive < 6)
        {        
            targetDive.spriteDive = RandomSpriteDive(GameObject.Find("ButtonGameDive" + (numberDive + 5).ToString()).GetComponent<CellDive>().spriteDive);
        }
        else
        {
            GoStupidDive();
            targetDive.spriteDive = GameObject.Find("ButtonGameDive" + (numberDive-5).ToString()).GetComponent<CellDive>().spriteDive;
            NewDestroy(GameObject.Find("ButtonGameDive" + (numberDive - 5).ToString()).GetComponent<CellDive>(), numberDive - 5);
        }
    }

    public void GameStart()
    {
        pointCountDive = false;
        horizontal = new List<int>
        {2,3,4,7,8,9,12,13,14,17,18,19,22,23,24,27,28,29};
        GoStupidDive();
        vertical = new List<int>
        {6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25};


        cellsDive = new List<CellDive>
        {
            cellDive11.GetComponent<CellDive>(),
            cellDive12.GetComponent<CellDive>(),
            cellDive13.GetComponent<CellDive>(),
            cellDive14.GetComponent<CellDive>(),
            cellDive15.GetComponent<CellDive>(),

            cellDive21.GetComponent<CellDive>(),
            cellDive22.GetComponent<CellDive>(),
            cellDive23.GetComponent<CellDive>(),
            cellDive24.GetComponent<CellDive>(),
            cellDive25.GetComponent<CellDive>(),

            cellDive31.GetComponent<CellDive>(),
            cellDive32.GetComponent<CellDive>(),
            cellDive33.GetComponent<CellDive>(),
            cellDive34.GetComponent<CellDive>(),
            cellDive35.GetComponent<CellDive>(),

            cellDive41.GetComponent<CellDive>(),
            cellDive42.GetComponent<CellDive>(),
            cellDive43.GetComponent<CellDive>(),
            cellDive44.GetComponent<CellDive>(),
            cellDive45.GetComponent<CellDive>(),

            cellDive51.GetComponent<CellDive>(),
            cellDive52.GetComponent<CellDive>(),
            cellDive53.GetComponent<CellDive>(),
            cellDive54.GetComponent<CellDive>(),
            cellDive55.GetComponent<CellDive>(),

            cellDive61.GetComponent<CellDive>(),
            cellDive62.GetComponent<CellDive>(),
            cellDive63.GetComponent<CellDive>(),
            cellDive64.GetComponent<CellDive>(),
            cellDive65.GetComponent<CellDive>()
        };
        GoStupidDive();
        foreach (var itemDive in cellsDive)
        {
            itemDive.spriteDive= RandomSpriteDive();
            itemDive.CellStart();
        }
        pointsDive = 0;
        pointGoalDive = 50 + pickedLevelDive * 10;
        GameObject.Find("GameCanvasDive").GetComponent<TimerScriptDive>().RefreshTimeDiver();


        GoStupidDive();

        BigGameCheckDive();
        pointCountDive = true;
    }
    public Sprite RandomSpriteDive(Sprite previousSprite = null)
    {
        Sprite tempSpriteDive;
        int rIntDive = rDive.Next(0, 4);
        if (rIntDive == 0) tempSpriteDive = sprite1Dive;
        else if (rIntDive == 1) tempSpriteDive = sprite2Dive;
        else if (rIntDive == 2) tempSpriteDive = sprite3Dive;
        else tempSpriteDive = sprite4Dive;
        GoStupidDive();
        if (previousSprite != null)
        {
            while (previousSprite.GetInstanceID() == tempSpriteDive.GetInstanceID())
            {
                rIntDive = rDive.Next(0, 4);
                if (rIntDive == 0) tempSpriteDive = sprite1Dive;
                else if (rIntDive == 1) tempSpriteDive = sprite2Dive;
                else if (rIntDive == 2) tempSpriteDive = sprite3Dive;
                else tempSpriteDive = sprite4Dive;
            }
        }
    

        return tempSpriteDive;
    }

    void SwapDive()
    {
     
        if ((Math.Abs(firstClickedDive.positionXDive - secondClickedDive.positionXDive) +Math.Abs(firstClickedDive.positionYDive - secondClickedDive.positionYDive))==1)
        {
            Vector3 firstTempDive = secondClickedDive.currentPositionDive;
            Vector3 secondTempDive = firstClickedDive.currentPositionDive;
            Sprite temp1 = secondClickedDive.spriteDive;
            Sprite temp2 = firstClickedDive.spriteDive;
            firstClickedDive.StartMoveDive(firstTempDive, temp1);
            secondClickedDive.StartMoveDive(secondTempDive, temp2);
            GoStupidDive();
        }
        else
        {
            firstClickedDive.RefreshSpriteDive();
            firstClickedDive = null;
            secondClickedDive = null;
            boolFirstDive = false;
            boolSecondDive = false;
        }
        GoStupidDive();
    }

 


    public void BigGameCheckDive()
    {
        TryCheck();

        while (destructionHappenedDive)
        {
            TryCheck();
            GoStupidDive();
        }
        foreach (var itemDive in cellsDive)
        {
            itemDive.RefreshSpriteDive();
        }
        scoreTextDive.text = "Score: " + pointsDive.ToString()+"/"+pointGoalDive.ToString();
    }



    void Update()
    {

        if (boolFirstDive && boolSecondDive)
        {
            boolFirstDive = false;
            boolSecondDive = false;
            if (firstClickedDive != secondClickedDive) SwapDive();
            else firstClickedDive.RefreshSpriteDive();
            GoStupidDive();
        }

        if (firstMoveFinishedDive && secondMoveFinishedDive)
        {
            firstMoveFinishedDive = false;
            secondMoveFinishedDive = false;
            BigGameCheckDive();
        }
    }
}
