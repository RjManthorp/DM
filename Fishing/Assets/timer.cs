using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
	float timeLeft = 30.0f;
	public Text timeText;
	public bool gameOver;
	public Button restart;
	public Text Text;

	public GameObject redBoat;
	public GameObject blueBoat;


	public Text Winner1;
	public Text Winner2;

	void Start()
	{
		Winner1.enabled = false;
		Winner2.enabled = false;

		restart.enabled = false;
		restart.image.enabled = false;
		Text.enabled = false;

		Button rePlay = restart.GetComponent<Button> ();
		rePlay.onClick.AddListener (restartScene);


	}



	void Update()
	{
		timeLeft -= 1*Time.deltaTime;

		timeText.text = timeLeft.ToString("F0");
		if(timeLeft <= 0)
		{
			Debug.Log("gameOver");

			gameOver = true;
			timeLeft = 0;

			if (redBoat.gameObject.GetComponent<scoreCountP2> ().p2Score > blueBoat.gameObject.GetComponent<scoreCounter> ().p1Score) 
			{
				Winner1.text = ("You Lose!");
				Winner2.text = ("You Win!");
			}
			if (redBoat.gameObject.GetComponent<scoreCountP2> ().p2Score < blueBoat.gameObject.GetComponent<scoreCounter> ().p1Score) 
			{
				Winner1.text = ("You Win!");
				Winner2.text = ("You Lose!");
			}

			if (redBoat.gameObject.GetComponent<scoreCountP2> ().p2Score == blueBoat.gameObject.GetComponent<scoreCounter> ().p1Score) 
			{
				Winner1.text = ("You Both Draw!");
				Winner2.text = ("You Both Draw!");
			}
				
			//restart.enabled = true;
			Winner1.enabled = true;
			Winner2.enabled = true;
			//timeText.enabled = false;

			restart.enabled = true;
			restart.image.enabled = true;
			Text.enabled = true;
		}
	}



	void restartScene()
	{
		SceneManager.LoadScene("1");
	}

}
