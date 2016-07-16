using UnityEngine;
using System.Collections;

public class destruir : MonoBehaviour {
    Animator mianimacion;
    float dura;
	// Use this for initialization
	void Start () {
        mianimacion = this.GetComponent<Animator>();
        RuntimeAnimatorController ac = mianimacion.runtimeAnimatorController;
        for (int i=0; i < ac.animationClips.Length; i++)
        {
            if(ac.animationClips[i].name =="explosion")
            {
                dura = ac.animationClips[i].length;
            }
        }
        StartCoroutine(Destroytimer());

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator Destroytimer()
    {
        yield return new WaitForSeconds(dura);
        Destroy(this.gameObject);
    }
}
