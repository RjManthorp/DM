using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timer : MonoBehaviour
{
	float timeLeft = 60.0f;
	public Text timeText;
	public bool gameOver;

	void Update()
	{
		timeLeft -= 1*Time.deltaTime;

		timeText.text = timeLeft.ToString("F0");
		if(timeLeft <= 0)
		{
			Debug.Log("gameOver");
			gameOver = true;
			timeLeft = 0;

		}
	}
}
