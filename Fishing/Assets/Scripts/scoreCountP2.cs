using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCountP2 : MonoBehaviour {


	public int p2Score;

	public Text playerTwoScore;
	public int fishCount2;


	public List<GameObject> caughtFishP2 = new List<GameObject> ();


	void Start()
	{
		// && caughtFishP2[0].GetComponent<fishMovement>().p2Zone == true && caughtFishP2[1].GetComponent<fishMovement>().p2Zone == true)
	}

	void Update()
	{
		playerTwoScore.text = p2Score.ToString ();
		if (fishCount2 == 2) 
		{
			checkFish1 ();
		}
	}

	void checkFish1()
	{

		for (int i = 0; i < caughtFishP2.Count; i++) 
		{
			if (caughtFishP2 [0].name.Contains ("Blue") && caughtFishP2 [1].name.Contains ("Blue")) {
				Debug.Log ("Its a match!");
				p2Score += 10;
			} 

			if (caughtFishP2 [0].name.Contains ("Pink") && caughtFishP2 [1].name.Contains ("Pink")) {
				Debug.Log ("Its a match!");
				p2Score += 10;

			} 
			if (caughtFishP2 [0].name.Contains ("Orange") && caughtFishP2 [1].name.Contains ("Orange"))
			{
				Debug.Log ("Its a match!");
				p2Score += 10;

			}
			if (caughtFishP2 [0].name.Contains ("Green") && caughtFishP2 [1].name.Contains ("Green"))
			{
				Debug.Log ("Its a match!");
				p2Score += 10;

			}
			if (caughtFishP2 [0].name.Contains ("Special") && caughtFishP2 [1].name.Contains ("Special"))
			{
				Debug.Log ("Its a match!");
				p2Score += 50;

			}

			else {
				Debug.Log ("no match");
			}

			caughtFishP2.Clear ();

			removeCaughtFish ();
		}
	}



	public void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.GetComponent<fishMovement> ().p2Zone == true) {
			col.gameObject.tag = "caughtFish";

			caughtFishP2.Add (col.gameObject);

			fishCount2 += 1;

		} 
	}
	void removeCaughtFish()
	{
		GameObject[] caughtFish = GameObject.FindGameObjectsWithTag ("caughtFish");


		for (int i = 0; i < caughtFish.Length; i++) 
		{
			Destroy (caughtFish [i]);

			fishCount2 = 0;

		}

	}
}