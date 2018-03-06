using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetScript : MonoBehaviour {

	[Header ("Net Components")]
	public Animator anim; 

	[Header ("Net Varibles")]
	public GameObject net1;
	public bool onNet;


	void Start () 
	{
		anim = GetComponent<Animator> ();
	}
	

	void Update ()
	{
		
		if (Input.GetKeyUp (KeyCode.A)) 
		{
			anim.SetBool("isSwinging", onNet);  

		}

	}


	public void finishedSwing()
	{
		Debug.Log ("finished");
		net1.gameObject.GetComponent<Animator> ().SetBool("isSwinging",onNet = false);
	}

}
