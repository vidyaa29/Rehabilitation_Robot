using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hatcontroller : MonoBehaviour {
public Camera cam;
	// Use this for initialization
float maxWidth;
//Rigidbody2D rbd = GetComponent<Rigidbody2D> ();
//Rigidbody2D rigidbody2D;
	void Start () 
	{
		//rigidbody2D = new GetComponent<Rigidbody2D>();
		//this.animation.Play();
		if (cam==null)
		{
			cam = Camera.main;
		}
		Vector3 upperCorner = new Vector3 (Screen.width, Screen.height,0.0f); 
		Vector3 targetWidth= cam.ScreenToWorldPoint(upperCorner);
		 //float HatWidth = new renderer.bounds.extents.x();
		maxWidth = targetWidth.x;
	//clamp the hat 
	//allow the screenspace to move the hat
	// Update is called once per physics timestep
    }
	void Update () 
	{
		float movespeed = 0.0f;
		movespeed++;
		Vector3 rawPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 targetPosition= new Vector3 (rawPosition.x,-6.0f,0.0f);
        float targetWidth = Mathf.Clamp(targetPosition.x,-maxWidth,maxWidth);
        targetPosition = new Vector3(targetWidth, targetPosition.y,targetPosition.z);
        //rbd=GetComponent<Rigidbody>();
        transform.position = new Vector3(targetPosition.x,targetPosition.y);

	}
}
