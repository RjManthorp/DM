using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickControl : MonoBehaviour {

	public bool p1firstFish;
	public bool p2firstFish;


	void Start()
	{
		//firstFish = true;
	}

	void Update() 
	{
		if (Input.GetMouseButtonDown(0)) 
		{
			Debug.Log("Pressed left click, casting ray.");
			CastRay();
		}
	}

	void CastRay()
	{
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		if (gameObject.GetComponent<timer> ().gameOver == false) {
			if (Physics.Raycast (ray, out hit, 100)) {
				if (hit.collider.gameObject.name.Contains ("A") || hit.collider.gameObject.name.Contains ("B")) {
					if (hit.collider.gameObject.GetComponent<Transform> ().position.y <= 0.0f && p1firstFish == false) {
						hit.collider.gameObject.transform.position = new Vector3 (-2.36f, -4.69f, -1f);
						hit.collider.gameObject.GetComponent<fishMovement> ().isMoving = false;
						//hit.collider.gameObject.gameObject.GetComponent<fishMovement> ().speed = 0.0F;
						p1firstFish = true;
					} else if (hit.collider.gameObject.GetComponent<Transform> ().position.y <= 0.0f && p1firstFish == true) {
						hit.collider.gameObject.transform.position = new Vector3 (-0.62f, -4.69f, -1f);
						hit.collider.gameObject.GetComponent<fishMovement> ().isMoving = false;
						//hit.collider.gameObject.gameObject.GetComponent<fishMovement> ().speed = 0.0F;
						p1firstFish = false;
					}
					if (hit.collider.gameObject.GetComponent<Transform> ().position.y >= 0.0f && p2firstFish == false) {
						hit.collider.gameObject.transform.position = new Vector3 (1.26f, 4.69f, -1f);
						hit.collider.gameObject.GetComponent<fishMovement> ().isMoving = false;
						//hit.collider.gameObject.gameObject.GetComponent<fishMovement> ().speed = 0.0F;
						p2firstFish = true;
					} else if (hit.collider.gameObject.GetComponent<Transform> ().position.y >= 0.0f && p2firstFish == true) {
						hit.collider.gameObject.transform.position = new Vector3 (-0.62f, 4.69f, -1f);
						hit.collider.gameObject.GetComponent<fishMovement> ().isMoving = false;
						//hit.collider.gameObject.gameObject.GetComponent<fishMovement> ().speed = 0.0F;
						p2firstFish = true;
					}
				}
			}
		}
	}




}
