using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour {
	public float timeDelay = 2f;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, timeDelay);
	}
}
