using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container2 : MonoBehaviour
{

void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "AltesTShirt")
        {
           
            Destroy(other.gameObject);
        }

        if (other.tag == "NormalesTShirt")
        {
                        Destroy(other.gameObject);
        }




    }


}
