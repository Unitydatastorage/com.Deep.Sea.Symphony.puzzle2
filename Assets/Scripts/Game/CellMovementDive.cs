using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class CellMovementDive : MonoBehaviour
{

    bool startDive = false;
    Vector3 position1Dive;
    Vector3 position2Dive;

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
    public void Transition(RectTransform firstDive, RectTransform secondDive)
    {
        GoStupidDive();
        position1Dive = firstDive.localPosition;
        position2Dive = secondDive.localPosition;
        startDive = true;

        if (firstDive.localPosition != position2Dive)
        {
            firstDive.localPosition = Vector3.Lerp(position1Dive, position2Dive, 0);
        }
        GoStupidDive();
        if (secondDive.localPosition != position1Dive)
        {
            secondDive.localPosition = Vector3.Lerp(position2Dive, position1Dive, 0);
        }
    }


}
