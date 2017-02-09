using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    Rigidbody2D rb2d;
    public int speed;
	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
            rb2d.velocity = Vector2.up * speed;
        if (Input.GetKey(KeyCode.S))
            rb2d.velocity = Vector2.down * speed;

    }
}
