     using UnityEngine;
     using UnityEngine.SceneManagement;
     using System.Collections;
     
     public class Restart : MonoBehaviour {
     //calls whatever scene is 2 less than the current one aka restarting in the context of
     //this game
         public void RestartGame() {
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
         }
     
     }