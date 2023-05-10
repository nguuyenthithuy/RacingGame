using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HaftPoinTrigger : MonoBehaviour {

	public GameObject LapcompleteTrig;
	public GameObject HaftPoninTrig;

	void OnTriggerEnter() { 
		LapcompleteTrig.SetActive(true);
		HaftPoninTrig.SetActive(false);
	}
}
