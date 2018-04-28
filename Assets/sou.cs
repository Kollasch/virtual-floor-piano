using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sou : MonoBehaviour
{

    private AudioSource note;
    private bool played = false;



    // Use this for initialization
    void Start()
    {
        note = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnMouseDown()
    {
        note.PlayOneShot(note.clip);
    }

        void OnMouseUp()
    {
        note.Stop();
    }

   private void OnCollisionEnter(Collision c)
   {
        if (played == false)
        {
            note.PlayOneShot(note.clip);
            played = true;
        }

   }

   void OnCollisionExit(Collision c)
   {
       note.Stop();
       played = false;
   }
 

}
