using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giroLuz : MonoBehaviour {
	public float Velocidadciclo;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.RotateAround (Vector3.left, Velocidadciclo);
		
	}
}
