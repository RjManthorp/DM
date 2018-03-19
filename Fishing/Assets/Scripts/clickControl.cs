using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickControl : MonoBehaviour {

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
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit, 100)) 
		{
			Debug.DrawLine(ray.origin, hit.point);
			Debug.Log (hit.collider.gameObject.name);
			hit.collider.gameObject.transform.position = new Vector3 (-0.56f, -4.69f, -1f);
		}
	}
}
