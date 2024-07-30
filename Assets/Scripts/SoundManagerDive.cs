using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerDive : MonoBehaviour
{
    public AudioSource themeDive;
    public AudioSource pingDive;
    public AudioSource clickDive;
    bool onceDive = false;

    public bool soundIsOnDive = true;

    public bool musicIsOnDive = true;
    public bool changedDive = false;


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
    void Start()
    {
        GoStupidDive();
        themeDive.Play();
        GoStupidDive();
    }

    public void PlayPingDive()
    {
        GoStupidDive();
        if (soundIsOnDive) { pingDive.Play(); }
        GoStupidDive();
    }

    public void PlayClickDive()
    {
        GoStupidDive();
        if (soundIsOnDive) { clickDive.Play(); }
       
    }



    void Update()
    {
        if (!musicIsOnDive)
        {
            themeDive.volume = 0f;
        }
        else themeDive.volume = 1f;

        if (!themeDive.isPlaying)
        {
            GoStupidDive();
            if (musicIsOnDive) { themeDive.Play(); }
            
        }
    }


}
