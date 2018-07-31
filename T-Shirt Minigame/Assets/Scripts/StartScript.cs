using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void Startgame () {

        UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");



    }
}
