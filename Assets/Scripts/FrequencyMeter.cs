using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrequencyMeter : MonoBehaviour {

    public int band;
    public float startScale = 1;
    public float scaleMultiplier = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale = new Vector3(transform.localScale.x, (ControllerScript.frequencies[band] * scaleMultiplier) + startScale, transform.localScale.z);
	}
}
