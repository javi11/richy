using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {
    public Transform player; //jugador
    private Vector3 positionCamera; //posición camara
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate() {
        positionCamera = new Vector3(player.transform.position.x,player.transform.position.y,transform.position.z);
        transform.position = Vector3.Lerp(transform.position, positionCamera, 10*Time.deltaTime);
	}
}
