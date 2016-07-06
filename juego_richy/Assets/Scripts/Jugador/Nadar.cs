using UnityEngine;
using System.Collections;

public class Nadar : MonoBehaviour
{

    public float jumpForce = 50f; //fuerza salto
    public Transform foot; //pie
    public LayerMask water; //agua
    public bool inWater = true; // en el agua
    public float radioFoot = 0.08f;
    int cuentasalto = 5;

    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().freezeRotation = true;

    }

    void FixedUpdate()
    {
        inWater = Physics2D.OverlapCircle(foot.position, radioFoot, water);
        if (Input.GetKey("up") && inWater == true)
        {
            //instrucciones
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x, 0);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce * cuentasalto));
        }
    }
}
