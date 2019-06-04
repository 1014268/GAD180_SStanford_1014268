﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Submarine : Ship
{
    public override void Initialize()
    {
        // load sprites for sub components
        SetSprite("hull", "Art/sub_hull");
        SetSprite("propulsion", "Art/sub_propulsion");
        SetSprite("weapon", "Art/sub_weapon");

        // scale the submarine
        transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);

        base.Initialize();
    }

    public override void Update()
    {

        base.Update();
    }
}