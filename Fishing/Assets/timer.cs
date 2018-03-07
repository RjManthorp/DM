using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timer : MonoBehaviour
{
	float timeLeft = 60.0f;
	public Text timeText;


	void Update()
	{
		timeLeft -= Time.deltaTime;
		//Debug.Log (timeLeft);
		timeText.text = timeText.ToString ();
		if(timeLeft < 0)
		{
			Debug.Log("gameOver");
		}
	}
}
