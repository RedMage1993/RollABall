using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset; // private because it can be set here.

	// Use this for initialization
	void Start () {
		// Take current transform position of camera
		// And subtract transform position of player
		// Necessary because you can't have the camera's position being exactly
		// that of the player's
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () { // Guaranteed to run after all items have been processed/updated
		transform.position = player.transform.position + offset;
	}
}
