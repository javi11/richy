using UnityEngine;
using System.Collections;

public class Muere : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "enemigo")
        {
            Destroy(other.gameObject, 0.05f);
        }
    }

}

