using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClassSelector : MonoBehaviour
{
    //public TextMeshProUGUI selection;
    public Text TextField;
    public Text ClassError;
    private static System.Random rand = new System.Random();
    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            ClassError.text = "Please choose a class for your character";
        }
        else
        {
            if (val == 1) //Barbarian
            {
                PlayerManager._instance.walkSpeed = rand.Next(10, 12);
                PlayerManager._instance.runSpeed = rand.Next(10, 12);
                PlayerManager._instance.jumpHeight = rand.Next(10, 12);
                
            }
            if (val == 10 || val == 12) //Sorcerer & Wizard
            {
                PlayerManager._instance.walkSpeed = rand.Next(9, 15);
                PlayerManager._instance.runSpeed = rand.Next(15, 20);
                PlayerManager._instance.jumpHeight = rand.Next(10, 21);
            }
            if (val == 5 || val == 7 || val == 8) //Fighter,Paladin,Ranger
            {
                PlayerManager._instance.walkSpeed = rand.Next(19, 25);
                PlayerManager._instance.runSpeed = rand.Next(25, 30);
                PlayerManager._instance.jumpHeight = rand.Next(20, 31);
            }
            if (val == 2 || val == 3 || val == 4 || val == 6 || val == 9 ||val == 11) //all other character classes
            {
                PlayerManager._instance.walkSpeed = rand.Next(29, 35);
                PlayerManager._instance.runSpeed = rand.Next(35, 40);
                PlayerManager._instance.jumpHeight = rand.Next(30, 40);
            }

            TextField.text = "Armor Class: " + PlayerManager._instance.armorClass +
                             "\nWalk speed: " + PlayerManager._instance.walkSpeed +
                             "\nRun speed: " + PlayerManager._instance.runSpeed +
                             "\nJump height: " + PlayerManager._instance.jumpHeight;
            PlayerManager._instance.playerClass = GetComponent<TMP_Dropdown>().options[val].text;
        }
        
    }

}
