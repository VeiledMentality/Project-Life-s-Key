using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterExit : MonoBehaviour {

    public string sceneName;
    public Vector3 positionTo;
    public GameObject player;

	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	void Update () {
		
	}

    public void init(string sceneName_, int id_, int targetID_)
    {
    }

    public void init(string sceneName_,int id_)
    {
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            SceneManager.LoadScene(sceneName);
            player.transform.position = positionTo;
        }
    }
}
