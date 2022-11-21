using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioWalking : MonoBehaviour
{

    private AudioSource aud;
    private bool isMoving;

    void Start()
    {

        aud = GetComponent<AudioSource>();

    }

    void Update()
    {


        if (Input.GetAxis("Vertical") < 0 || Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Vertical") > 0 || Input.GetAxis("Horizontal") < 0)
            isMoving = true;
        else
            isMoving = false;


        if (isMoving && !aud.isPlaying) aud.Play(); // if player is moving and audiosource is not playing play it

        if (!isMoving) aud.Stop(); // if player is not moving and audiosource is playing stop it
    }
}
