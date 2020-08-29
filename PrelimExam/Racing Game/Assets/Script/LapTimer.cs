using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimer : MonoBehaviour
{
    public static int MinuteCount;
    public static int SecondsCount;
    public static float MilliCount;
    public static string MilliDisplay;


    public GameObject MinuiteBox;
    public GameObject SecondsBox;
    public GameObject MilliBox;



    // Update is called once per frame
    void Update()
    {
        MilliCount += Time.deltaTime * 10;
        MilliDisplay = MilliCount.ToString("f0");
        MilliBox.GetComponent<Text>().text = "" + MilliDisplay;
        
        if(MilliCount >= 10)
        {
            MilliCount = 0;
            SecondsCount += 1; 
        }

        if(SecondsCount <= 9)
        {
            SecondsBox.GetComponent<Text>().text = "0" + SecondsCount + ".";
        }
        else
        {
            SecondsBox.GetComponent<Text>().text = "" + SecondsCount + ":";
        }
        if(SecondsCount >= 60)
        {
            SecondsCount = 0;
            MinuteCount += 1;            
        }
        if(MinuteCount<= 9)
        {
            MinuiteBox.GetComponent<Text>().text = "0" + MinuteCount + ":";
        }
        else
        {
            MinuiteBox.GetComponent<Text>().text = "" + MinuteCount + ":";
        }
    }
}
