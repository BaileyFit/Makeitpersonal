using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityStandardAssets.ImageEffects;

public class CamEffects : MonoBehaviour {

    public Flowchart flowchart;
    public float unhappiness;
    AudioSource audio;
    public float audiopitch = 1;



    // Use this for initialization
    void Start () {
        audio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        unhappiness = flowchart.GetFloatVariable("Unhappiness");
        if (unhappiness > 1)
        {
            unhappiness = 1;
        }
        GetComponent<Grayscale>().effectAmount = unhappiness;
        audio.pitch = audiopitch - unhappiness/8;

	}
}
