using UnityEngine;
using System.Collections;

public class Moneda : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "moneda")
        {
            Destroy(other.gameObject, 0.05f);
        }
    }
}
