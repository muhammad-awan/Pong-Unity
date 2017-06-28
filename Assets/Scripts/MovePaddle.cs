using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePaddle : MonoBehaviour {

    
    public float speed = 50;

    void FixedUpdate()
    {
        // If you want paddle to move horizontally as well:
        //float vertPress = Input.GetAxisRaw("Vertical");
        //float horPress = Input.GetAxisRaw("Horizontal");

        //    if (vertPress != 0f) {
        //        GetComponent<Rigidbody2D>().velocity = new Vector2(0, vertPress) * speed;

        //    }
        //    else
        //    {
        //        GetComponent<Rigidbody2D>().velocity = new Vector2(horPress, 0) * speed;
        //    }

        float vertPress = Input.GetAxisRaw("Vertical");

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, vertPress) * speed;

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
