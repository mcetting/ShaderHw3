using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW3 : MonoBehaviour
{
    [Header("Homework")]
    [SerializeField] private ParticleSystem particle;
    [SerializeField] private float beatTimer;
    private float timer;

    private enum state
    {
        red, blue, green, yellow
    }
    state myState;

    void Start()
    {
        myState = state.red;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer <= Time.time)
        {
            timer = Time.time + beatTimer;
            particle.Play();
            if(myState == state.red)
            {
                particle.startColor = Color.red;
                myState = state.blue;
            }
            else if (myState == state.blue)
            {
                particle.startColor = Color.blue;
                myState = state.green;
            }
            else if (myState == state.green)
            {
                particle.startColor = Color.green;
                myState = state.yellow;
            }
            else if (myState == state.yellow)
            {
                particle.startColor = Color.yellow;
                myState = state.red;
            }
        }
    }
}
