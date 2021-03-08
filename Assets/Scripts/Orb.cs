﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : TellPlayer
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        UseItem();
    }


    public override void UseItem()
    {
        base.UseItem();
        Calories = GetComponent<TellPlayer>().Calories;
        Karmas = GetComponent<TellPlayer>().Karmas;
    }
}
