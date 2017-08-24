using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject player;
    public GameObject[] EnterExitList;

    public static bool exists = false;

	void Start () {

        dontDestroyOnLoad();

        player = GameObject.Find("Player");


    }


	void Update () {

        EnterExitList = GameObject.FindGameObjectsWithTag("EnterExit");
    }


    private void dontDestroyOnLoad()
    {
        if (exists == false)
        {
            DontDestroyOnLoad(transform.gameObject);
            exists = true;
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
