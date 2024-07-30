using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;


public class LevelActivatorDive : MonoBehaviour
{

    public Button button2Dive;
    public Button button3Dive;
    public Button button4Dive;
    public Button button5Dive;
    public Button button6Dive;
    public Button button7Dive;
    public Button button8Dive;
    public Button button9Dive;
    public Button button10Dive;
    public Button button11Dive;
    public Button button12Dive;
    public Button button13Dive;
    public Button button14Dive;
    public Button button15Dive;
    public Button button16Dive;
    public Button button17Dive;
    public Button button18Dive;
    public Button button19Dive;
    public Button button20Dive;


    public int currentLevelDive = -1;


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

    public void ActivateButtonsDive()
    {
        GoStupidDive();
        GoStupidDive();
        currentLevelDive++;
        int tempDive = currentLevelDive;
        List<Button> buttonsDive = new List<Button>
        {
         button2Dive,button3Dive,button4Dive,button5Dive,button6Dive,button7Dive,button8Dive,button9Dive,button10Dive,button11Dive,button12Dive,button13Dive,button14Dive,button15Dive,button16Dive,button17Dive,button18Dive,button19Dive,button20Dive
};

        GoStupidDive();
        while (tempDive > -1)
        {
            buttonsDive[tempDive].GetComponent<Button>().interactable = true;
            tempDive--;
        }
        GoStupidDive();
    }
}
