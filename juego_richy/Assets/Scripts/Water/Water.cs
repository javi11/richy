using UnityEngine;
using System.Collections;

public class Water : MonoBehaviour
{
    public float gravityW = 0.5f;
    public float massW = 3f;
    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "Player")
        {
            obj.gameObject.GetComponent<Rigidbody2D>().gravityScale = gravityW;
            obj.gameObject.GetComponent<Rigidbody2D>().mass = massW;
        }
    }

}

