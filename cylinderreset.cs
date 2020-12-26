using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinderreset : MonoBehaviour {
	Vector3 originalpos;

	
	void Start () {
		originalpos=transform.localPosition;
		
	}
	
	void Update () {
		
	}
	void OnTriggerEnter(Collider collide)
	{
		if (collide.gameObject.CompareTag("cylin"))
		{
			transform.localPosition = originalpos;
		}

	}
}
