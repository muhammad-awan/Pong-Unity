using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float speed = 50;
    private Rigidbody2D rigidBody;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = Vector2.right * speed;

	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        //LeftPaddle & RightPaddle
        if (( collision.gameObject.name == "LeftPaddle") || (collision.gameObject.name == "RightPaddle"))
        {
            HandlePaddleHit(collision);
        }

    
        //LeftGoal & RightGoal
        if ((collision.gameObject.name == "LeftGoal") || (collision.gameObject.name == "RightGoal"))
        {
            transform.position = new Vector2(0, 0);
        }
    }

    void HandlePaddleHit(Collision2D collision)
    {
        float y = BallHitPaddleWhere(transform.position,
            collision.transform.position,
            collision.collider.bounds.size.y);

        Vector2 dir = new Vector2();

        if(collision.gameObject.name == "LeftPaddle")
        {
            dir = new Vector2(1, y).normalized;
        }

        if (collision.gameObject.name == "RightPaddle")
        {
            dir = new Vector2(-1, y).normalized;
        }

        rigidBody.velocity = dir * speed;

    }

    float BallHitPaddleWhere(Vector2 ball, Vector2 paddle, float paddleHeight)
    {
        return (ball.y - paddle.y) / paddleHeight;
    }

}
