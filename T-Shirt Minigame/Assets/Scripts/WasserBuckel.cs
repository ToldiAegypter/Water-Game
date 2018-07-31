using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Muelleimer : MonoBehaviour
{


    public Counter counter;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "NormalesTShirt" || other.tag == "NormalesTShirt")
        {
          
            Destroy(other.gameObject);
        }

    }
}