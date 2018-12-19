using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SeekPlayer : MonoBehaviour {
	//setting variables for Navmesh and gameobject
	NavMeshAgent nav;
	public Transform target;
	
	// Use this for initialization
	void Start () {
		//Assigns variable Nav to a specific task aka getting the NavMeshAgent component
		nav = GetComponent<NavMeshAgent>();
			}
	
	// Update is called once per frame
	void Update () {
		//Tells object to go to targets position
		nav.destination = target.position;
	}
}
