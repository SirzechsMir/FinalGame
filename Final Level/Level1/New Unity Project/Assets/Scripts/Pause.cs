﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

    private Text text;

    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Pause1();
        }
    }

    private void Pause1()
    {
        text.enabled = !text.enabled;
        Time.timeScale = Time.timeScale == 0 ? 1 : 0; // Ternary statement
       // PlayAudio();

        /*
        if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
        } else
        {
            Time.timeScale = 0;
        }
        */
    }

   /* private void PlayAudio()
    {
        if (Time.timeScale == 0)
        {
            paused.TransitionTo(0.01f);
        }
        else
        {
            unpaused.TransitionTo(0.01f);
        }
    }*/
}
