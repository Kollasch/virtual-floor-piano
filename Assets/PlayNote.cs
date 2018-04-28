using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayNote : MonoBehaviour {

    // Use this for initialization
    private AudioSource note = null;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



   }

    private void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.GetComponent<AudioSource>() != null)
        {
            note = c.gameObject.GetComponent<AudioSource>();
            note.PlayOneShot(note.clip);

        }
        print("Piano Sound");
    }

    void OnCollisionExit(Collision c)
   {
        if (note)
        {
            note.Stop();
        }
   }
  
}
