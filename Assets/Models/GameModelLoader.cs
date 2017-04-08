using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
public class GameModelLoader : MonoBehaviour {


    static int row;
    
    // Use this for initialization
    void Start()
    {
        XmlDocument doc = new XmlDocument();
        doc.Load("Assets\\Models\\GameModel.xml");

        //Display all the book titles.
        
        XmlNodeList elemList = doc.GetElementsByTagName("row");
       
        foreach(XmlNode x in elemList)
        {
            row =XmlConvert.ToInt32( x.InnerText);
        }
        print(row);

    }
}
