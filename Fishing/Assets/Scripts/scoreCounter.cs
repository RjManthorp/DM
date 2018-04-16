using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreCounter : MonoBehaviour {

public bool isCollidedFish1 = false;
public bool isCollidedFish2 = false;



public void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag.Contains("1"))
			isCollidedFish1 = true;
		else if (col.gameObject.tag.Contains("2"))
			isCollidedFish2 = true;

	if (isCollidedFish1 && isCollidedFish2)
			Destroy(col.gameObject);

	}


}