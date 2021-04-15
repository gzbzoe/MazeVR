using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpendDoor : MonoBehaviour {
    public GameObject door_r;
    public GameObject door_l;
    public bool isOpen = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Debug.Log(transform.GetChild(0).rotation.x);
        if (transform.GetChild(0).rotation.x < -0.1f && isOpen)
        {
            isOpen = false;
            door_r.transform.Rotate(0, 90, 0);
            door_l.transform.Rotate(0, -90, 0);

        }
    }
    public void open()
    {
        
    }
      
}
