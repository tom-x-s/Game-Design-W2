using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float movementSpeed = 1;
    private InputBehaviour _inputB;

	// Use this for initialization
	void Start ()
    {
        _inputB = GetComponent<InputBehaviour>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (_inputB.Drag())
        {
            Vector3 MovementDirection = _inputB.GetMovementDirection();
            Vector3 movement = new Vector3(MovementDirection.x, 0, MovementDirection.y) * Time.deltaTime * movementSpeed;
            transform.Translate(movement);
        }


        if (_inputB.Tap())
        {
            Debug.Log("Tap");
        }

        if (_inputB.DoubleTap())
        {
            Debug.Log("DoubleTap");
        }

        switch (_inputB.Swipe()){
            case 0:
                break;
            case 1:
                Debug.Log("SwipeUp");
                break;
            case 2:
                Debug.Log("SwipeDown");
                break;
            case 3:
                Debug.Log("SwipeRight");
                break;
            case 4:
                Debug.Log("SwipeLeft");
                break;
        }

    }
}
