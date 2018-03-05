using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class controls : MonoBehaviour {

	public Button catch1;
	public Button catch2;

	public GameObject net1;
	public bool onNet;


	// Use this for initialization
	void Start () 
	{
		Button btn1 = catch1.GetComponent<Button>();
		Button btn2 = catch2.GetComponent<Button>();
		btn1.onClick.AddListener(click1);
		btn2.onClick.AddListener(click2);
	}
	
	void click1()
	{
		Debug.Log ("click1");

	}

	void click2()
	{
		Debug.Log ("click2");
	}

	void Update () 
	{

	}
			
}
