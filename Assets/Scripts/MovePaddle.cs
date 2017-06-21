using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePaddle : MonoBehaviour {

    //public float speed = 10.0F;
    //void FixedUpdate()
    //{
    //    float moveVert = Input.GetAxisRaw("Vertical") * speed;
    //    float moveHor = Input.GetAxisRaw("Horizontal") * speed;
    //    GetComponent<Rigidbody2D>().velocity = new Vector2(moveVert, 0);
    //    GetComponent<Rigidbody2D>().velocity = new Vector2(0, moveHor);

    //}
    public float speed = 50;

    void FixedUpdate()
    {

        float vertPress = Input.GetAxisRaw("Vertical");
        float horPress = Input.GetAxisRaw("Horizontal");

        if ( vertPress != 0f) {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, vertPress) * speed;
            
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(horPress, 0) * speed;
        }

        //float vertPress = Input.GetAxisRaw("Vertical");
        //Rigidbody2D rigid = GetComponent<Rigidbody2D>();

        
    }
        // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
