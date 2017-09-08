﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mammal : Animal {
	
	//Functions
	//Live Birth
	//Nurse

	public override void Start()
	{
		base.Start();
		LiveBirth();
	}

    void LiveBirth()
    {
        print(this.name + " Gives Live Birth");
    }

    //Parameters
    public string hair = "Fur";
	//Hair
	public Color hairColor = Color.black;
	//Hair Color
	public string type = "Quadra Ped";
	//BiPed/QuadraPed/MonoPed

}
