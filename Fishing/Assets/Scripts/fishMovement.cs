using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishMovement : MonoBehaviour 
{
	
	public float speed = 1.5f;
	public float rotateSpeed = 5.0f;

	public bool isMoving;
	public bool p2Zone;

	public bool endOfGame;

	public GameObject clock;

	Vector2 newPosition;

	void Start ()
	{
		PositionChange();
		isMoving = true;
	}

	void PositionChange()
	{
		newPosition = new Vector2(Random.Range(-4.5f, 4.5f), Random.Range(-4f, 4f));
	}

	void Update ()
	{
		if (isMoving == true) {
			if (Vector2.Distance (transform.position, newPosition) < 1)
				PositionChange ();

			transform.position = Vector2.Lerp (transform.position, newPosition, Time.deltaTime * speed);

			LookAt2D (newPosition);
			
		}
		if (gameObject.GetComponent<Transform> ().position.y >= 0)
		{
			p2Zone = true;
		}
		if (gameObject.GetComponent<Transform> ().position.y <= 0)
		{
			p2Zone = false;
		}

		if (endOfGame == true) 
		{
			endGame ();
		}

		if (gameObject.GetComponent<Transform> ().localScale.x <0.00f && gameObject.GetComponent<Transform> ().localScale.y <0.00 && gameObject.GetComponent<Transform> ().localScale.z <0.00) 
		{
			endOfGame = false;
			Destroy (gameObject);
		}

		if (clock.GetComponent<timer>().gameOver == true) 
		{
			endGame ();
		}

	}


	void endGame()
	{
		for (int i = 0; i < 99; i++) {
			transform.localScale -= new Vector3 (0.00001f, 0.00001f, 0.00001f);
		}




	}


	void LookAt2D(Vector3 lookAtPosition)
	{
		float distanceX = lookAtPosition.x - transform.position.x;
		float distanceY = lookAtPosition.y - transform.position.y;
		float angle = Mathf.Atan2(distanceX, distanceY) * Mathf.Rad2Deg;

		Quaternion endRotation = Quaternion.AngleAxis(angle, Vector3.back);
		transform.rotation = Quaternion.Slerp(transform.rotation, endRotation, Time.deltaTime * rotateSpeed);
	}
}