using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (AudioSource))]
public class ControllerScript : MonoBehaviour {
    AudioSource aSource;
    public static float[] samples = new float[512];
    public static float[] frequencies = new float[8];

	// Use this for initialization
	void Start () {
        aSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        GetSpectrumAudioSource();
        makeFrequencyBands();
	}

    void GetSpectrumAudioSource() {
        aSource.GetSpectrumData(samples, 0, FFTWindow.Blackman);
    }

    // divide frequencies into bands
    void makeFrequencyBands(){
        int count = 0;

        for (int i = 0; i < 8; ++i){
            float average = 0;
            int sampleCount = (int)Mathf.Pow(2, i) * 2;

            if(i == 7){
                sampleCount += 2;
            }

            for (int j = 0; j < sampleCount; ++j){
                average += samples[count] * count + 1;
                    count++;
            }
            average /= count;

            frequencies[i] = average * 10;
        }
    }
}
