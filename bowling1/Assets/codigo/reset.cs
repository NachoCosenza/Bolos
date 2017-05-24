using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour {

	private Vector3 lugarInicio;
	private Vector3 anguloInicio;
	private Rigidbody rb;
	public KeyCode retry = KeyCode.R;
	private Quaternion QuaInucio;

	public AudioClip aplausos;


	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
		lugarInicio = transform.position;
		QuaInucio = transform.rotation;

		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if (Input.GetKey (retry)) 
		{
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
			rb.position = lugarInicio;

			rb.MoveRotation (QuaInucio);

			AudioSource.PlayClipAtPoint (aplausos, lugarInicio);

		}
		
	}
}
