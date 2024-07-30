using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonVolumeDive : MonoBehaviour
{
    public bool isSound = true;
    public bool isActive = true;
    public Button counterpartDive;
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
    public void OnClickDive()
    {
        if (!isActive)
        {
            GoStupidDive();
            isActive = true;
            counterpartDive.GetComponent<ButtonVolumeDive>().isActive = false;
            if (isSound)
            {
                GoStupidDive();
                GameObject.Find("SoundTextDive").GetComponent<SoundButtonsDive>().PressDive();
            }
            else
            {
                GameObject.Find("MusicTextDive").GetComponent<SoundButtonsDive>().PressDive();
            }
        }
    }

}
