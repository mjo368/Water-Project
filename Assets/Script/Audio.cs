﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{

    public static Audio instance; 
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        instance = this; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
