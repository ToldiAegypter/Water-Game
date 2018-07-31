using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCounter : MonoBehaviour {
    public TextMesh Countertext;
    private GameObject herz;
    int AnzahlTshirtsanZeiger = 12;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Countertext.text = AnzahlTshirtsanZeiger.ToString();
    }
}
