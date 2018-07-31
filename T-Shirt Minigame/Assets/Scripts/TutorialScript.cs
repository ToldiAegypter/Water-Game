using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void Tutorial () {

        UnityEngine.SceneManagement.SceneManager.LoadScene("Tutorial");



    }
}
