using UnityEngine;
using System.Collections;

public class bloke_rompe : MonoBehaviour {

    public GameObject explosion;

	void OnTriggerEnter2D( Collider2D other)
    {
        if (other.gameObject.tag == "rompe")
        {
            Instantiate(explosion, other.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
        }
    }
	
}
