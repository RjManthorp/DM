using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishMovement : MonoBehaviour 
{
	
		public float speed = 1.5f;
		public float rotateSpeed = 5.0f;

		Vector2 newPosition;

		void Start ()
		{
			PositionChange();
		}

		void PositionChange()
		{
			newPosition = new Vector2(Random.Range(-3.5f, 3.5f), Random.Range(-3.5f, 3.5f));
		}

		void Update ()
		{
			if(Vector2.Distance(transform.position, newPosition) < 1)
				PositionChange();

			transform.position=Vector2.Lerp(transform.position,newPosition,Time.deltaTime*speed);

			LookAt2D(newPosition);
			
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