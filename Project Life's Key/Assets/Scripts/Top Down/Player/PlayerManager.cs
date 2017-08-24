using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public bool isMovingU,isMovingD,isMovingL,isMovingR;
    public float moveSpeed = 2;
    public Animator animator;
    private PlayerInventory pInv;
    private bool testBool = true;
    public static bool exists = false;

    void Start() {
        if (exists == false)
        {
            DontDestroyOnLoad(transform.gameObject);
            exists = true;
        } else
        {
            Destroy(gameObject);
        }
        animator = GetComponent<Animator>();
        pInv = new PlayerInventory();
        pInv.initInventory();
    }
	
	// Update is called once per frame
	void Update () {

        animator.SetBool("isMovingD", isMovingD);
        animator.SetBool("isMovingR", isMovingR);
        animator.SetBool("isMovingU", isMovingU);
        animator.SetBool("isMovingL", isMovingL);

        if(Input.GetKey(KeyCode.A))
        {
            isMovingL = true;
            transform.Translate(new Vector3(-moveSpeed * Time.deltaTime, 0f,0f));

        } else
        {
            isMovingL = false;
        }

        if(Input.GetKey(KeyCode.D))
        {
            isMovingR = true;
            transform.Translate(new Vector3(moveSpeed * Time.deltaTime,0f,0f));
        } else
        {
            isMovingR = false;
        }

        if (Input.GetKey(KeyCode.S))
        {
            isMovingD = true;
            transform.Translate(new Vector3(0f, -moveSpeed * Time.deltaTime,0f));
        } else
        {
            isMovingD = false;
        }

        if(Input.GetKey(KeyCode.W))
        {
            isMovingU = true;
            transform.Translate(new Vector3(0f, moveSpeed * Time.deltaTime,0f));
        } else
        {
            isMovingU = false;
        }


	}
}
