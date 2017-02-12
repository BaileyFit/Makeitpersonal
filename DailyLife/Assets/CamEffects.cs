using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityStandardAssets.ImageEffects;

public class CamEffects : MonoBehaviour {

    public Flowchart flowchart;
    public float unhappiness;


   

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        unhappiness = flowchart.GetFloatVariable("Unhappiness");
        GetComponent<Grayscale>().effectAmount = unhappiness;
	}
}
