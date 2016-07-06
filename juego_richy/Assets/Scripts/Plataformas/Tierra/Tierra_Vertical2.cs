using UnityEngine;
using System.Collections;

public class Tierra_Vertical2 : MonoBehaviour
{
    public float plataformSped = 0.5f;
    float startPoint;
    public float limit = 0.7f;
    bool dir = true;
    // Use this for initialization
    void Start()
    {
        startPoint = transform.position.y; //Guarda la posición inicial de la paltaforma.
    }

    // Update is called once per frame
    void Update()
    {
        if (dir)
        {
            if (transform.position.y < startPoint + limit)
            {
                transform.position = transform.position + new Vector3(0, plataformSped * Time.deltaTime, 0);
            }
            else
            {
                dir = false;
            }
        }
        else
        {
            if (transform.position.y > startPoint - limit)
            {
                transform.position = transform.position - new Vector3(0, plataformSped * Time.deltaTime, 0);
            }
            else
            {
                dir = true;
            }
        }
    }
}