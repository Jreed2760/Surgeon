using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class Score : MonoBehaviour {
 
 
 
    public Text MyText;
    private int speedNum;
    private int score;
    public bool Active;
     
    // Use this for initialization
    void Start () {
        MyText.text = "";
    }
 
 
    // Update is called once per frame
    void Update () {
        //If Number is reached, change scene to scene #2 aka winning screen
     if (score == 14){
        SceneManager.LoadScene (3);
     }
     //sets the score for the game
        MyText.text = "Animal Parts: " + score;     	
    }
 // Keeping track of the score
   void OnCollisionEnter(Collision col){ 
		if (col.gameObject.CompareTag("Parts")){ 
            score = score + 1;
        }
			
     
    }
     
}