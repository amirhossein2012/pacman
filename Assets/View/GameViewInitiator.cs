using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class GameViewInitiator : MonoBehaviour {
    GameObject[] sprites;
    public Texture2D wall_texture;
    Sprite sp;
    // Use this for initialization
    void Start()
    {
        GameInitiator.Start();
        Rect rect = new Rect();
        rect.center = new Vector2(0, 0);
        rect.height = 0.5f;
        rect.width = 0.5f;
        sp = Sprite.Create(wall_texture, rect, new Vector2(0.5f, 0.5f), 1);

        sprites = new GameObject[100];
         for (int i = 0; i < 10; i++)
         {
            for (int j = 0; j < 10; j++)
            {
                if (GameData.map[i, j] == 1)
                {
                    sprites[i * j] = new GameObject();
                    sprites[i * j].AddComponent<SpriteRenderer>();
                    sprites[i * j].GetComponent<SpriteRenderer>().sprite = sp;
                    sprites[i * j].transform.localScale = new Vector3(1, 1, 0);

                    sprites[i * j].transform.position = new Vector3(-10 + (float)i / 2.0f, 5 - (float)j / 2.0f);
                }
            }
            
        }
        
    }

}
