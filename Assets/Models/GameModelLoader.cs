﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
public class GameModelLoader : MonoBehaviour {

    //Get data from xml file
    static int row,col,square_size,wall_density;
    void Start()
    {
        XmlDocument doc = new XmlDocument();
        doc.Load("Assets\\Models\\GameModel.xml");

        //setting tags
        XmlNodeList elemList = doc.GetElementsByTagName("row");
        foreach(XmlNode x in elemList)
        {
            row =XmlConvert.ToInt32( x.InnerText);
        }
        elemList = doc.GetElementsByTagName("col");

        foreach (XmlNode x in elemList)
        {
            col = XmlConvert.ToInt32(x.InnerText);
        }
        elemList = doc.GetElementsByTagName("squaresize");

        foreach (XmlNode x in elemList)
        {
            square_size = XmlConvert.ToInt32(x.InnerText);
        }
        elemList = doc.GetElementsByTagName("wallDensity");
       
        foreach(XmlNode x in elemList)
        {
            wall_density =XmlConvert.ToInt32( x.InnerText);
        }
       

    }
}
