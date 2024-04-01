using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public KeyCode moveUp;
    public KeyCode MoveDown;
    public float speed = 10f;
    public float boundY;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Movement()
    {
        var vel = rb2d.velocity;
        if(Input.GetKey(moveUp)) vel.y = speed;
        else if(Input.GetKey(MoveDown)) vel.y = -speed;
        else vel.y = 0;
        rb2d.velocity = vel;
    }

    private void Boundaries()
    {
        var pos = transform.position;
        if(pos.y > boundY) pos.y = boundY;
        else if(pos.y < -boundY + 1.75f) pos.y = -boundY + 1.75f;
        transform.position = pos;
    }

    void Update()
    {
        Movement();
        Boundaries();
    }
}
