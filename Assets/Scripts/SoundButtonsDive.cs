using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButtonsDive : MonoBehaviour
{
    public Sprite onStateDive1;
    public Sprite offStateDive1;

    public Sprite onStateDive2;
    public Sprite offStateDive2;

    public Button buttonOnDive;
    public Button buttonOffDive;

    public bool isSound;
    
    public bool activeDive=true;

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

    public void PressDive()
    {
        activeDive = !activeDive;

        GoStupidDive();
        if (activeDive)
        {
            buttonOnDive.GetComponent<Image>().sprite=onStateDive1;
            buttonOffDive.GetComponent<Image>().sprite = offStateDive2;
            GoStupidDive();
        }
        else
        {
            buttonOnDive.GetComponent<Image>().sprite = offStateDive1;
            buttonOffDive.GetComponent<Image>().sprite = onStateDive2;
        }

        if (isSound) GameObject.Find("MainCameraDive").GetComponent<SoundManagerDive>().soundIsOnDive = activeDive;
        else GameObject.Find("MainCameraDive").GetComponent<SoundManagerDive>().musicIsOnDive = activeDive;
        GoStupidDive();
    }


}

