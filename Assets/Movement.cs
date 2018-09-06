using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private InputBehaviour _inputB;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (_inputB.Tap())
        {
            Debug.Log("Move");
        }

        if (_inputB.DoubleTap())
        {
            Debug.Log("Dash");
        }


    }
}
