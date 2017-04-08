using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class GameViewInitiator : MonoBehaviour {
    GameObject sprite;
    public Sprite sp;
    // Use this for initialization
    void Start()
    {
       
        sprite = new GameObject();
        sprite.AddComponent<SpriteRenderer>();
        sprite.GetComponent<SpriteRenderer>().sprite = sp;
    }

}
