using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate1 : MonoBehaviour {
    public GameObject samplePrefab;
    GameObject[] samplesArr = new GameObject[512];
    public float maxScale = 1000;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < 512; ++i){
            GameObject instanceOfSample = (GameObject)Instantiate(samplePrefab);
            instanceOfSample.transform.position = this.transform.position;
            instanceOfSample.transform.parent = this.transform;
            instanceOfSample.name = "SampleCube" + i;
            this.transform.eulerAngles = new Vector3(0, -0.703125f * i, 0);
            instanceOfSample.transform.position = Vector3.forward * 100;
            samplesArr[i] = instanceOfSample;
        }
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(this.transform.position, 90f);
            
        for (int i = 0; i < 512; ++i){
            if(samplesArr != null){
                samplesArr[i].transform.localScale = new Vector3(10, (ControllerScript.samples[i] * maxScale) + 2, 10);
            }
        }
	}
}
