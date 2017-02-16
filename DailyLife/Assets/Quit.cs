using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Quit : MonoBehaviour {

    public Flowchart flowchart;
    public bool quit;

	// Use this for initialization
	void Start () {
        quit = flowchart.GetBooleanVariable("Quit");

    }
	
	// Update is called once per frame
	void Update () {
		if(flowchart.GetBooleanVariable("Quit") == true)
        {
            Application.Quit();
            Debug.Log("quit");
        }
	}
}
