using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public float speed = 1f;
    public GameObject killer;
    Rigidbody2D rb2d;
	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.left * speed;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < killer.transform.position.x)
            DestroyObject(gameObject);
	}
}
