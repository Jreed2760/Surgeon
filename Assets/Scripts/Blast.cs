using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	public class Blast : MonoBehaviour {

	void Update () {
		//Sets up New Raycast to be attached to a "MainCamera"
		Ray blastt = Camera.main.ScreenPointToRay(Input.mousePosition);
		//Setting variable to hold raycast info
		RaycastHit hit = new RaycastHit();
		if (Physics.Raycast(blastt, out hit, 1000f)){
			if (Input.GetMouseButton(0)){
				//when I left click, send whatever object I clicked on that has a rigidbody
				//X distance
				if (hit.rigidbody){
					hit.rigidbody.AddForce(Random.insideUnitSphere * 850f);
					
				
						}
		}
	}
}
}