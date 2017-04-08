﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour {
    //Game database
    public static int row, col, square_size, wall_density;
    public static int[,] map;
    public void initiate()
    {
        row = GameModelLoader.row;
        col = GameModelLoader.col;
        square_size = GameModelLoader.square_size;
        wall_density = GameModelLoader.wall_density;
        map = new int[row, col];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                map[i, j] = 0;
            }
        }
    }
	void Start () {

        initiate();

	}
	
	
}
