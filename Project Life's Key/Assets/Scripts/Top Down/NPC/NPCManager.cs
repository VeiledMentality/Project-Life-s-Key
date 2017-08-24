using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour {

    public string[] speech;
    
    // Value: -1.  Why?: Inside the addSpeech method, we add 1 onto the speechCounter so that we will start with 0 in the array speech. _C = Code
    public int speechCounter_C = -1;
    // _V = Value for in-game.
    public int speechCounter_V = 0; 

    void Start () {
        addSpeechLength(5);
        addSpeech("Hello traveler! Mind if I ask you a question?");

    }

	void Update () {
		
	}



    private void addSpeechLength(int length)
    {
        speech = new string[length];
    }


    private void addSpeech(string text)
    {
        if (speechCounter_C >= speech.Length)
        {

        }
        else
        {
            speech[speechCounter_C + 1] = text;
            speechCounter_C += 1;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
         if(collision.gameObject.name == "Player")
        {
            Debug.Log(speech[speechCounter_V]);
        }
    } 

}
