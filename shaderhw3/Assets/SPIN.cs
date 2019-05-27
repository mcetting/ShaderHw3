﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPIN : MonoBehaviour
{
    [SerializeField]
    private float spin;
    [SerializeField]
    private Vector3 axis;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(axis * spin * Time.deltaTime);
    }
}
