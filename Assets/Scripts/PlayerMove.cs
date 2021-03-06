﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour {


    Rigidbody myBody;
    public float forceAmt;
    // Use this for initialization
    void Start () {
        myBody = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update () {
    	//Allows player to move although with NavMeshAgent, forceAmt becomes irrelevant.
    	//Kept as a backup to movement. Will continue to mess with NavMeshAgent movement is weird.
        if (Input.GetKey(KeyCode.W))
            myBody.AddForce(Vector3.forward * forceAmt);
        if (Input.GetKey(KeyCode.S))
            myBody.AddForce(Vector3.back * forceAmt);
        if (Input.GetKey(KeyCode.A))
            myBody.AddForce(Vector3.left * forceAmt);
        if (Input.GetKey(KeyCode.D))
            myBody.AddForce(Vector3.right * forceAmt);


    }
    void OnCollisionEnter(Collision col){ 
    	//Checking the tag of the object this current game object is colliding with
		if (col.gameObject.CompareTag("Parts" )){ 			
			//if the size of the game object is smaller than the object it collided with
			//this stuff happens
			if (transform.lossyScale.sqrMagnitude < col.transform.lossyScale.sqrMagnitude ){
					transform.gameObject.GetComponent<AudioSource>().Play();
					col.gameObject.SetActive(false);
	}
		if (col.gameObject.CompareTag("Enemy")){ 			
			//suppose to be a game ending script however it doesn't seem to respond to the player collision
			if (transform.lossyScale.sqrMagnitude > col.transform.lossyScale.sqrMagnitude ){
				gameObject.SetActive(false);
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
}
}
}
}