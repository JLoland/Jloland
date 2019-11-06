using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmClock : MonoBehaviour
{
    public GameObject Bear;
    //poop
    public GameObject Mouse;
    private int count = 0;
    private bool OnOff = true;
    public GameObject Audio;

    // Update is called once per frame
    void Update()
    {
        if(count <= 3)
        {

        }
        else
        {

        }
    }

    public void Switch()
    {
        if (OnOff == true)
        {
            Audio.GetComponent<AudioSource>().Pause();
            OnOff = false;
        }
        else
        {
            Audio.GetComponent<AudioSource>().Play();
            OnOff = true;
        }
    }
}
