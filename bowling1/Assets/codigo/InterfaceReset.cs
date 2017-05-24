using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceReset : MonoBehaviour {
	public KeyCode retry = KeyCode.R;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (retry))
		{
			//GetComponent<MeshRenderer> ().material.color = Color.blue;
		}
		
	}
}
