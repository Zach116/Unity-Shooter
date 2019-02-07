using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCameraMovement : MonoBehaviour {
	public Transform player;

	// Use this for initialization
	void Start () {
		Vector3 initialPosition = new Vector3 (player.transform.position.x, (player.transform.position.y + 10f), player.transform.position.z);
		transform.position = initialPosition;
	}
	
	// Update is called once per frame
	void Update () {
		MoveCamera ();
	}

	// Move the top-down camera to allign with the player
	void MoveCamera () {
		Vector3 cameraPosition = new Vector3 (player.transform.position.x, transform.position.y, player.transform.position.z);
		transform.position = cameraPosition;
	}
}
