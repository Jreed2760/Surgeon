using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour {
	
	public void StartGame(){
		//Switches to the next scene in the build setup
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
