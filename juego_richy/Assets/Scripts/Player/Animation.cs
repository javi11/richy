using UnityEngine;
using System.Collections;

public class Animation : MonoBehaviour
{
    public Animator anim;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        anim.SetFloat("speed", Mathf.Abs(gameObject.GetComponent<Rigidbody2D>().velocity.x));
        anim.SetBool("inFloor", gameObject.GetComponent<Movements>().inFloor);
        anim.SetBool("isSwimming", gameObject.GetComponent<Movements>().isSwimming);
        anim.SetBool("isDuck", gameObject.GetComponent<Movements>().isDuck);

        if (gameObject.GetComponent<Rigidbody2D>().velocity.x > 0) {
            gameObject.transform.localScale= new Vector3(1,1,1);
        }
        if (gameObject.GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
