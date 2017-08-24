using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;
    public GameObject player;
    public GameObject cam; 
	// Use this for initialization
	void Start () {
        player = GameObject.FindWithTag("Player");
        cam = GameObject.FindWithTag("Camera");
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0,0,1 * speed * Time.deltaTime));
            player.transform.position += new Vector3(0,0,1 * speed * Time.deltaTime);
            
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            player.transform.position += new Vector3(-1 * speed * Time.deltaTime,0,0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
            player.transform.position += new Vector3(0, 0, -1* speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            player.transform.position += new Vector3(1 * speed * Time.deltaTime, 0, 0);
            cam.transform.position += new Vector3(1 * speed * Time.deltaTime, 0, 0);
        }

    }
}
