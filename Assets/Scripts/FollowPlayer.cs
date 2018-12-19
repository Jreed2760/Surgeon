using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
//creats two variables. One for an object as a reference.
// One for the offsetting of manual Vector3 position
	public Transform player;
	public Vector3 offset;
	
	// Update is called once per frame
	void Update () {
		// Allows an offset position to be manually set for gameobject
		transform.position = player.position + offset;
			
	}
}
