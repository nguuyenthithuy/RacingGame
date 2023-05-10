using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour {

	public static int MinuteCount;
	public static int SecondCount;
	public static float MiliCount;

	public static string MiliDisPlay;

	public GameObject MinuteBox;
	public GameObject SecondBox;
	public GameObject MiliBox;
	
	// Update is called once per frame
	void Update () {
		MiliCount += Time.deltaTime*10;
		
		MiliDisPlay = MiliCount.ToString("F0");
		MiliBox.GetComponent<Text>().text = ""+ MiliDisPlay;

		if (MiliCount >= 10)
		{
			SecondCount += 1;
			MiliCount = 0;
		}
		if(SecondCount <= 9)
		{
			SecondBox.GetComponent<Text>().text = "0" + SecondCount + ".";
		}
		else
		{
			SecondBox.GetComponent<Text>().text=SecondCount + ".";
		}
		if (SecondCount >= 60)
		{
			MinuteCount += 1;
			SecondCount = 0;
		}
		if (MinuteCount <= 9)
		{
			MinuteBox.GetComponent<Text>().text ="0"+MinuteCount + ":";

		}
		else
		{
			MinuteBox.GetComponent<Text>().text=MinuteCount + ":";
		}
	}
}
