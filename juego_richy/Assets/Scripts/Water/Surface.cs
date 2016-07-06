using UnityEngine;
using System.Collections;

public class Surface : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D obj2)
    {
        if (obj2.gameObject.tag == "Player")
        {
            obj2.gameObject.GetComponent<Rigidbody2D>().gravityScale = 2f;
            obj2.gameObject.GetComponent<Rigidbody2D>().mass = 1f;
        }
    }

}

