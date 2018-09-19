using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (AudioSource))]
public class ControllerScript : MonoBehaviour {
    AudioSource aSource;
    public static float[] samples = new float[512];

	// Use this for initialization
	void Start () {
        aSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        GetSpectrumAudioSource();
	}

    void GetSpectrumAudioSource() {
        aSource.GetSpectrumData(samples, 0, FFTWindow.Blackman);
    }
}
