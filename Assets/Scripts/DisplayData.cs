using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class DisplayData : MonoBehaviour
{
    public Text Textfield;
    public void DisplayCharData()
    {
        BinaryFormatter bf = new BinaryFormatter();
        System.IO.StreamReader file =
            new System.IO.StreamReader(Application.persistentDataPath + "/CharacterData.json");
        string line;
        string data = "";
        while((line = file.ReadLine()) != null)  
        {
            data += line;
        }

        Textfield.text = data;
        file.Close();
    }
}
