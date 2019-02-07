using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// When a bullet hits an object labeled enemy destroy it
	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "Enemy")
		{
			Destroy (col.gameObject);
		}
	}
}
