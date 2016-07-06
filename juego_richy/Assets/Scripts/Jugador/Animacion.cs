using UnityEngine;
using System.Collections;

public class Animacion : MonoBehaviour
{
    public Animator anim;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("velocidad", Mathf.Abs(gameObject.GetComponent<Rigidbody2D>().velocity.x));
        anim.SetBool("ground", gameObject.GetComponent<Movimiento>().inFloor);
        anim.SetBool("water", gameObject.GetComponent<Nadar>().inWater);
        anim.SetBool("isDuck", gameObject.GetComponent<Movimiento>().isDuck);
        if (gameObject.GetComponent<Rigidbody2D>().velocity.x > 0) {
            gameObject.transform.localScale= new Vector3(1,1,1);
        }
        if (gameObject.GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
