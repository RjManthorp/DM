using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class controls : MonoBehaviour {

	public Button catch1;
	public Button catch2;
	public Button catch1_A;
	public Button catch2_A;

	public GameObject net1;
	public GameObject net2;

	private Animator anim; 

	public bool onNet;


	// Use this for initialization
	void Start () 
	{
		Button btn1 = catch1.GetComponent<Button>();
		Button btn2 = catch2.GetComponent<Button>();
		Button btn1A = catch1_A.GetComponent<Button>();
		Button btn2A = catch2_A.GetComponent<Button>();
		btn1.onClick.AddListener(click1);
		btn2.onClick.AddListener(click2);
		btn1A.onClick.AddListener(click1_A);
		btn2A.onClick.AddListener(click2_A);

		anim = GetComponent<Animator> (); 

		onNet = true;
	}
	
	void click1()
	{
		Debug.Log ("click1");
		net1.gameObject.GetComponent<Animator> ().SetBool("isSwinging", true );

	}

	void click2()
	{
		Debug.Log ("click2");
		net2.gameObject.GetComponent<Animator> ().SetBool("isSwinging", true );
	}

	void click1_A()
	{
		Debug.Log ("click1A");
	}

	void click2_A()
	{
		Debug.Log ("click2A");
	}

	void Update () 
	{

	}
			
}
