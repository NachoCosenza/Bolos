using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pino : MonoBehaviour {

	private Vector3 lugarInicio;
	private Vector3 anguloInicio;
	private Rigidbody rb;
	public KeyCode retry = KeyCode.R;
	private Quaternion QuaInucio;
	public GameObject inter;
	public Transform posi;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();

		lugarInicio = transform.position;
		QuaInucio = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (rb.velocity != Vector3.zero) 
		{
			//Instantiate (inter, posi.position);
		}		
	}
}
