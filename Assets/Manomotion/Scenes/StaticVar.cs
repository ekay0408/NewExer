using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaticVar : MonoBehaviour
{
    public Text counted;
    public Text countedSummary;

    void Update()
    {
        int receivedCount = TriggerGizmo.count;
        if (receivedCount >= 10 && receivedCount <= 13)
        {
            counted.text = "" + receivedCount.ToString();
            countedSummary.text = "Nice Job!";
        }
        else if (receivedCount > 14)
        {
            counted.text = "" + receivedCount.ToString();
            countedSummary.text = "Please Slow Down!";
        }
        else if (receivedCount <= 9)
        {
            counted.text = "" + receivedCount.ToString();
            countedSummary.text = "Please Follow The Exercise!";
        }
    }
}
