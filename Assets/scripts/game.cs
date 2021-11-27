using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class game : MonoBehaviour {

	public Camera cam;
	public GameObject ball;
	public float tl;
	public Text timerText;
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
		StartCoroutine(Spawn()); 
    }
    //Vector3 spawnPosition;
    //fixed update regular update of the document, but not every frame per sec.
    void FixedUpdate()
    {
       tl -= Time.deltaTime;
       if(tl>=0)
       {
       	timerText.text = "TimeLeft:" + Mathf.RoundToInt(tl).ToString();
       }
    }
  IEnumerator Spawn()
  { yield return new WaitForSeconds(2.0f);
    while(tl>0)
  	{
  	Vector3 spawnPosition = new Vector3 (Random.Range(-maxWidth,maxWidth),11.0f,0.0f);
    
  	Quaternion spawnRotation = Quaternion.identity; // no rotation

  	Instantiate(ball, spawnPosition, spawnRotation);
    yield return new WaitForSeconds(Random.Range(1.0f,2.0f));   //wait for the balls to come down
    }
  }
}
