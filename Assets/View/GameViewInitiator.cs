﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameViewInitiator : MonoBehaviour {
   
	// Use this for initialization
	void Start () {
        GameInitiator.Start();
        GameObject spriteObject = new GameObject();
        spriteObject.AddComponent<SpriteRenderer>();
        spriteObject.GetComponent<SpriteRenderer>().color = Color.black;

    }
    

}
