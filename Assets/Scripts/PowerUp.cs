﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class PowerUp : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject imgAsset;
    public AimData aim = new AimData();
    void Awake()
    {
        
    }
    void Start()
    {
    }
    public abstract void activate(Cart user);
    // Update is called once per frame
    void Update()
    {
        
    }
}
