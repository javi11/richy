using UnityEngine;
using System.Collections;

public class Enemigo : MonoBehaviour {

    Vector3 positionX;
    public float margenes = 1f;
    public float velocidad = 2f;
    bool derecha = false;
	// Use this for initialization
	void Start () {
        positionX = this.transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	    if (derecha)
        {
            if (this.transform.position.x > positionX.x + margenes)
            {
                derecha = false;
                this.transform.localScale = new Vector3(1, 1, 1);
            }
            else
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector3(velocidad, this.GetComponent<Rigidbody2D>().velocity.y, 0);
            }
        }else
        {
            if (this.transform.position.x < positionX.x - margenes)
            {
                derecha = true;
                this.transform.localScale = new Vector3(-1, 1, 1);
            }
            else
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector3(-velocidad, this.GetComponent<Rigidbody2D>().velocity.y, 0);
            }
            }
	}
}
