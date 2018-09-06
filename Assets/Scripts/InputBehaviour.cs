using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBehaviour : MonoBehaviour {

    public bool startedDoubleTap;
    private float timeSinceFirstTap;

    public float tapInterval = 0.5f;

    // Use this for initialization
    void Start ()
    {
		
	}

    public bool Drag()
    {
        if (Input.touchCount == 0) return false;
        return true;
    }

    public Vector2 GetMovementDirection()
    {
        if (Input.touchCount == 0) return Vector2.zero;
        Touch touch = Input.GetTouch(0);

        Vector2 screenPosition = touch.position;
        Vector2 middleOfScreen = new Vector2(Screen.width / 2f, Screen.height / 2f);

        Vector2 positionDelta = screenPosition - middleOfScreen;

        return positionDelta.normalized;
    }


    public bool Tap()
    {
        if (Input.touchCount == 0) return false;
        Touch touch = Input.GetTouch(0);
        if (touch.phase == TouchPhase.Ended)
        {
            return true;
        }
        return false;
    }

    public bool DoubleTap()
    {
        if (Input.touchCount == 0) return false;
        Touch touch = Input.GetTouch(0);
        if (touch.phase == TouchPhase.Ended)
        {
            if (startedDoubleTap)
            {
                if (timeSinceFirstTap < tapInterval)
                {
                    startedDoubleTap = false;
                    timeSinceFirstTap = 0;
                    return true;
                }
            }
            else
            {
                startedDoubleTap = true;
                timeSinceFirstTap = 0;
                return false;
            }
        }

        return false;
    }

    public int Swipe()
    {

        if (Input.touchCount == 0) return 0;
        Touch touch = Input.GetTouch(0);
        if (touch.phase == TouchPhase.Ended)
        {
         
        }
        
        return 0;

    }

    // Update is called once per frame
    void Update ()
    {
        if (startedDoubleTap)
        {
            timeSinceFirstTap += Time.deltaTime;
            if (timeSinceFirstTap > tapInterval)
            {
                startedDoubleTap = false;
                timeSinceFirstTap = 0;
            }
        }

        if (Input.touchCount == 0) return;
        Touch touch = Input.GetTouch(0);

    }
}
