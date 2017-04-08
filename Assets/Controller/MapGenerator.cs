﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MapGenerator  {
    int row, col,wall_density;
    int[,] map;
    static System.Random rnd ;
    MapGenerator()
    {
        row = GameData.row;
        col = GameData.col;
        wall_density = GameData.wall_density;
        map = new int[row, col];
        rnd = new System.Random();
        randomMap();
        updateData();
    }
    void randomMap()
    {
        for(int i=0;i< row;i++)
        {
            
            for(int j = 0; j < col; j++)
            {
                int k=rnd.Next() % 100+1;
                //should be done : check if map is valid or not
                // 
                if (k > wall_density)
                {
                    map[i, j] = 1;
                }
                else
                {
                    map[i, j] = -1;
                }
            }
        }
    }
    bool isValid()
    {
        //check if wall is ok or not
        return true;
    }

    void updateData()
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                GameData.map[i, j] = map[i, j];
            }
        }
    }
	
}
