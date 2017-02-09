using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreator : MonoBehaviour {
    public float frequency = 1f;
    public float bulletSpeed = 2f;
    public float mapWidth = 20;
    public float mapHeight = 10;
    bool isReady = true;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (isReady)
            StartCoroutine(CreateBullet());
    }
    IEnumerator CreateBullet()
    {
        isReady = false;
        GameObject bullet = Instantiate(Resources.Load("bullet"), transform.position + Vector3.up * Random.Range(-5,5),Quaternion.identity) as GameObject;
        bullet.GetComponent<Bullet>().speed = bulletSpeed;
        yield return new WaitForSeconds(frequency);
        isReady = true;
    }
}
