using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour {

	private AudioSource note;
    private bool played = false;

    //Added Sound functionality
    private Renderer keyColor;
    private bool white;

    private Color whiteKey;
    private Color pressedWhite;
    private Color blackKey;
    private Color pressedBlack;



    // Use this for initialization
    void Start () {
		note = GetComponent<AudioSource>();
        keyColor = GetComponent<Renderer>();

        whiteKey = new Color(215, 215, 215);
        pressedWhite = Color.blue;
        //pressedWhite = new Color(255, 255, 224);
        blackKey = Color.black;
        pressedBlack = Color.blue;
        //pressedBlack = new Color(0, 0, 31);

        if (this.gameObject.tag == "WhiteKey")
        {
            print("white");
            white = true;
            keyColor.material.color = whiteKey;
        }
        if(this.gameObject.tag == "BlackKey")
        {
            print("black");
            white = false;
            keyColor.material.color = blackKey;
        }

    }

    // Update is called once per frame
    void Update(){
    }

        void OnMouseDown() {
            note.PlayOneShot(note.clip);
        }

        void OnMouseUp() {
            note.Stop();
        }

    private void OnCollisionEnter(Collision c)
    {
        print("piano sound = " + c.collider.gameObject.name);
       /* foreach (ContactPoint contact in c.contacts)
        {
            print(contact.thisCollider.name + " hit by " + contact.otherCollider.name);
        }*/
        if (played == false)
        {
            note.PlayOneShot(note.clip);
            played = true;
        }
        if (white)
        {
            keyColor.material.color = pressedWhite;
        }
        else
        {
            keyColor.material.color = pressedBlack;
        }
    }

    void OnCollisionExit(Collision c)
    {
        note.Stop();
        print("Halt");
        played = false;

        if (white)
        {
            keyColor.material.color = whiteKey;
        }
        else
        {
            keyColor.material.color = blackKey;
        }
    }
    

}
