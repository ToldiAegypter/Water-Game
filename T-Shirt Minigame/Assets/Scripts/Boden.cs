using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boden : MonoBehaviour
{


    public Counter counter;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "AltesTShirt" || other.tag == "AltesTShirt")
        {
            counter.Hearts(1);
            Debug.Log("Counter: " + counter.heart);
            Destroy(other.gameObject);
        }

    }
}