using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class DetectInput : MonoBehaviour

{
    //public PlayerManager.Player myPlayer;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("CharacterName").GetComponent<TMP_InputField>().onEndEdit.AddListener(setName);
        GameObject.Find("RedIDInput").GetComponent<TMP_InputField>().onEndEdit.AddListener(displayText);
        //gameObject.GetComponent<TMP_InputField>().onEndEdit.AddListener(setName);
        //gameObject.GetComponent<TMP_InputField>().onEndEdit.AddListener(displayText);
        
        
        
    }

    public Text TextField;
    public void setName(string playerName)
    {
        PlayerManager._instance.playerName = playerName;
    }
    public void displayText(string textInField)
    {
        PlayerManager._instance.armorClass = int.Parse(textInField);
        TextField.text = "Armor Class: " + PlayerManager._instance.armorClass +
                         "\nWalk speed: " + PlayerManager._instance.walkSpeed +
                         "\nRun speed: " + PlayerManager._instance.runSpeed +
                         "\nJump height: " + PlayerManager._instance.jumpHeight;
    }
    
}
