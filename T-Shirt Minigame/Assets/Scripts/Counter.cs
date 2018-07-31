using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour {

    int Gesamtpunkte = 0;
    int heart = 3;
    public TextMesh Countertext;
    private GameObject herz;



    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {


    }

    public void MehrPunkte(int Punkte)
    {
        Gesamtpunkte = Gesamtpunkte + Punkte;
        Countertext.text = Gesamtpunkte.ToString();
    }
     public void Hearts(int heartSub)
    {
        if (heart >= 2) {
            heart = heart - heartSub;
                }
        else {
            herz = GameObject.Find("Herz1");
            GameObject.Destroy(herz);
            //goto "Game Over"
            UnityEngine.SceneManagement.SceneManager.LoadScene("DieScene");
        }
        if(heart == 2)
        {
            herz = GameObject.Find("Herz2");
            GameObject.Destroy(herz);
        }
        if (heart == 1)
        {
            herz = GameObject.Find("Herz3");
            GameObject.Destroy(herz);
        }
    }
}
