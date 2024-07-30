using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CellDive : MonoBehaviour
{

    public int positionXDive;
    public int positionYDive;
    public Sprite spriteDive;
    public Vector3 currentPositionDive;
    public bool needsDestructionDive = false;



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
        
        if (!GameObject.Find("GameCanvasDive").GetComponent<GameLogicDive>().boolFirstDive)
        {
            GetComponent<UnityEngine.UI.Image>().color = Color.green;
            GameObject.Find("GameCanvasDive").GetComponent<GameLogicDive>().firstClickedDive = this;
            GameObject.Find("GameCanvasDive").GetComponent<GameLogicDive>().boolFirstDive = true;
            GoStupidDive();
        }
        else if (!GameObject.Find("GameCanvasDive").GetComponent<GameLogicDive>().boolSecondDive)
        {
            GameObject.Find("GameCanvasDive").GetComponent<GameLogicDive>().secondClickedDive = this;
            GameObject.Find("GameCanvasDive").GetComponent<GameLogicDive>().boolSecondDive = true;
        }
        GoStupidDive();
    }

    public void RefreshSpriteDive()
    {
        GetComponent<UnityEngine.UI.Image>().color = Color.white;
        GoStupidDive();
        GetComponent<UnityEngine.UI.Image>().sprite = spriteDive;
    }




    public void StartMoveDive(Vector3 destinationDive, Sprite newSpriteDive)
    {
        GetComponent<UnityEngine.UI.Image>().color = Color.white;
        GoStupidDive();
        StartCoroutine(moveObjectDive(destinationDive, newSpriteDive));
    }

    public IEnumerator moveObjectDive(Vector3 destinationDive, Sprite newSpriteDive)
    {
        float totalMovementTimeDive = 1f; 
        float currentMovementTimeDive = 0f;
        GoStupidDive();
        while (Vector3.Distance(transform.localPosition, destinationDive) > 0)
        {
            currentMovementTimeDive += Time.deltaTime;
            transform.localPosition = Vector3.Lerp(currentPositionDive, destinationDive, currentMovementTimeDive / totalMovementTimeDive);
            yield return null;
        }
        transform.localPosition = currentPositionDive;
        spriteDive = newSpriteDive;
        RefreshSpriteDive();
        if (GameObject.Find("GameCanvasDive").GetComponent<GameLogicDive>().firstMoveFinishedDive == false)
        {
            GameObject.Find("GameCanvasDive").GetComponent<GameLogicDive>().firstMoveFinishedDive = true;
        }
        else GameObject.Find("GameCanvasDive").GetComponent<GameLogicDive>().secondMoveFinishedDive = true;

    }


    public void CellStart()
    {
        GoStupidDive();
        currentPositionDive = transform.localPosition;
        RefreshSpriteDive();
    }

  
   
}
