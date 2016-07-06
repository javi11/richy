using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour {


	void OnTriggerEnter2D (Collider2D obj) {
        if (obj.gameObject.tag == "Player"){
            Application.LoadLevel(Application.loadedLevel);
        }
	
	}

}
