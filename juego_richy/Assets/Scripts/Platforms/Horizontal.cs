using UnityEngine;
using System.Collections;

public class Horizontal : MonoBehaviour
{
    public float plataformSpeed = 1.5f;
    float startPoint;
    public float limit = 1f;
    bool dir = true;
    // Use this for initialization
    void Start()
    {
        startPoint = transform.position.x; //Guarda la posición inicial de la paltaforma.
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (dir)
        {
            if (transform.position.x < startPoint + limit)
            {
                transform.position = transform.position + new Vector3(plataformSpeed * Time.deltaTime, 0, 0);
            }
            else
            {
                dir = false;
            }
        }
        else
        {
            if (transform.position.x > startPoint - limit)
            {
                transform.position = transform.position - new Vector3(plataformSpeed * Time.deltaTime, 0, 0);
            }
            else
            {
                dir = true;
            }
        }
    }
}

