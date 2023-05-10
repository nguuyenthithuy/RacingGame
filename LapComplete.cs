using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour {

	public GameObject HaftLapTRig;
	public GameObject Completetrig;

	public GameObject MinuteDisPlay;
	public GameObject SecondDisplay;
	public GameObject MiliDisplay;

    void OnTriggerEnter()
    {
        if(LapTimeManager.SecondCount <= 9)
		{
			SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount+".";
		}
		else
		{
			SecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecondCount+".";
		}
		if (LapTimeManager.MinuteCount <= 9)
		{
			MinuteDisPlay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount+":";
		}
		else
		{
			MinuteDisPlay.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount+":";
		}
		MiliDisplay.GetComponent<Text>().text = ""+ LapTimeManager.MiliCount;

		LapTimeManager.MinuteCount = 0;
		LapTimeManager.SecondCount = 0;
		LapTimeManager.MiliCount = 0;

		Completetrig.SetActive(false);
		HaftLapTRig.SetActive(true);

	}
}
