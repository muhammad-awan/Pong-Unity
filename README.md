#### Pong in Unity 

Add this script to your left paddle:

```
public float speed = 50;
    void FixedUpdate()
    {
        float vertPress = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, vertPress) * speed;
    }
```
