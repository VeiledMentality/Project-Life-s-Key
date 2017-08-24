using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestScript : MonoBehaviour {
    
	void Start () {
        Scene randScene = SceneManager.GetActiveScene();
        Debug.Log("Scene: " + randScene.name);
	}
	
	void Update () {
		
	}
}
