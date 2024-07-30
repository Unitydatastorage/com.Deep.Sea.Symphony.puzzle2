using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCanvasDive : MonoBehaviour
{
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


    public void JumpDive(string destinationDive)
    {
        GoStupidDive();
        GameObject.Find("MainCameraDive").GetComponent<SoundManagerDive>().PlayClickDive();
        GameObject.Find("MainCameraDive").GetComponent<CanvasHolderDive>().MoveDive(destinationDive,false);
    }


    public void JumpDiveLevel(int levelDive)
    {
        GoStupidDive();
        GameObject.Find("GameCanvasDive").GetComponent<GameLogicDive>().pickedLevelDive = levelDive;
        JumpDive("gameDive");
        GoStupidDive();
    }


    public void JumpBackDive()
    {
        GoStupidDive();
        GameObject.Find("MainCameraDive").GetComponent<SoundManagerDive>().PlayClickDive();
        GameObject.Find("MainCameraDive").GetComponent<CanvasHolderDive>().MoveBackDive();
    }

    public void JumpOKDive()
    {
        GoStupidDive();
        GameObject.Find("MainCameraDive").GetComponent<SoundManagerDive>().PlayClickDive();
        GameObject.Find("MainCameraDive").GetComponent<CanvasHolderDive>().MoveToOKDive();
    }

    public void CloseDive()
    {
        GoStupidDive();
        AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
        activity.Call<bool>("moveTaskToBack", true);
        GoStupidDive();
    }
}
