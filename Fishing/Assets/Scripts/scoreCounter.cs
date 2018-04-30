using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoreCounter : MonoBehaviour {


public int p1Score;
//public int p2Score;
public Text playerOneScore;

public int fishCount1;






public List<GameObject> caughtFishP1 = new List<GameObject> ();


	void Start()
	{
		// && caughtFishP2[0].GetComponent<fishMovement>().p2Zone == true && caughtFishP2[1].GetComponent<fishMovement>().p2Zone == true)
	}

	void Update()
	{

		
		if (fishCount1 == 2) 
		{
			checkFish1 ();
		}
		playerOneScore.text = p1Score.ToString ();

		for (int i = 0; i < caughtFishP1.Count; i++)
		{
			if (caughtFishP1 [i].gameObject.GetComponent<Transform> ().position.y >= 0) 
			{
				
			}
			
		}

	}

	void checkFish1()
	{
		
		for (int i = 0; i < caughtFishP1.Count; i++) 
		{
			if (caughtFishP1 [0].name.Contains ("Blue") && caughtFishP1 [1].name.Contains ("Blue")) {
				Debug.Log ("Its a match!");
				p1Score += 10;
			} 

			if (caughtFishP1 [0].name.Contains ("Pink") && caughtFishP1 [1].name.Contains ("Pink")) {
				Debug.Log ("Its a match!");
				p1Score += 10;

			} 
			if (caughtFishP1 [0].name.Contains ("Orange") && caughtFishP1 [1].name.Contains ("Orange"))
			{
				Debug.Log ("Its a match!");
				p1Score += 10;

			}

			else {
				Debug.Log ("no match");
			}
	
			caughtFishP1.Clear ();
				
			removeCaughtFish ();
		}
	}



public void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.GetComponent<fishMovement> ().p2Zone == false) {
			col.gameObject.tag = "caughtFish";

			caughtFishP1.Add (col.gameObject);

			fishCount1 += 1;

		} 
}
	void removeCaughtFish()
	{
		GameObject[] caughtFish = GameObject.FindGameObjectsWithTag ("caughtFish");


		for (int i = 0; i < caughtFish.Length; i++) 
		{
			Destroy (caughtFish [i]);

			fishCount1 = 0;

		}

	}
}