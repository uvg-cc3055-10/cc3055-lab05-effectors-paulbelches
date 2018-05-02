using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 Paul Belches
 17088
 paulbelches@gmail.com
 Script de los effectors
 */
public class AreaEffector : MonoBehaviour {
    float time = 0;
    public GameObject gameObject;
    ParticleSystem particle;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        time = time + Time.deltaTime;
        if (time > 5)
        {
            if (gameObject.active)
                gameObject.SetActive(false);
                
            else
                gameObject.SetActive(true);
            time = 0;
        }
	}
}
