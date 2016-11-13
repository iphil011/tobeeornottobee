using UnityEngine;
using System.Collections;

public class beeScore : MonoBehaviour {
    public bool isFull;
    public bool isEmpty;
    public int value;
	// Use this for initialization
	void Start () {
        value = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
        if (value == 50)
        {
            isFull = true;
        }
        else
        {
            isFull = false;
        }
        if (value == 0)
        {   
            isEmpty = true;
        }
        else {
            isEmpty = false;
        }

	
	}
}
