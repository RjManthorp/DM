using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class netMovement : MonoBehaviour {

	public float delta = 1.5f;  // Amount to move left and right from the start point
	public float speed = 2.0f;
	public float direction = 1;
	private Quaternion startPos;
	public bool net1Clicked;

//	void Start()
//	{
//		startPos = transform.rotation;
//	}

	IEnumerator start()
	{
			StartCoroutine("swingNet",2.0f);
			yield return new WaitForSeconds (1);
			StopCoroutine ("swingNet");
	}

	IEnumerator swingNet(float waitTime)
	{
		while (true) 
		{
			Quaternion a = startPos;
			a.z += direction * (delta * Mathf.Sin (Time.time * speed));
			transform.rotation = a;
			yield return null;
		}
	}


}
