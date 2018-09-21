using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateScript : MonoBehaviour {
    public GameObject lightPrefab;
    GameObject[] meters = new GameObject[8];

	// Use this for initialization
	void Start () {
        makeLights();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void makeLights(){
        for (int i = 0; i < 8; ++i)
        {
            GameObject newLight = (GameObject)Instantiate(lightPrefab);
            newLight.transform.position = this.transform.position;
            newLight.transform.parent = this.transform;
            newLight.name = "Frequency" + i;
            newLight.transform.position += Vector3.right * i;
            meters[i] = newLight;
            FrequencyToLight lightScript = newLight.GetComponent<FrequencyToLight>();
            lightScript.band = i;
        }
    }
}
