using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrequencyToLight : MonoBehaviour {
    public int band;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("here");
        this.GetComponent<Light>().range = ControllerScript.frequencies[band];
    }
}
