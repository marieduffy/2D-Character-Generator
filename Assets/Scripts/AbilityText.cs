using System;
using UnityEngine;
using UnityEngine.UI;

public class AbilityText : MonoBehaviour
{
    public Text Textfield;
    private static System.Random rand = new System.Random();

    public int UPPER = 7;
    //Players must roll 7d4 and
    //add the three highest rolls to compute each of the six Abilities


    public void SetStrength()
    {
        PlayerManager._instance.strength = SetText();
    }
    public void SetDexterity()
    {
        PlayerManager._instance.dexterity = SetText();
    }
    public void SetConstitution()
    {
        PlayerManager._instance.constitution = SetText();
    }
    public void SetIntelligence()
    {
        PlayerManager._instance.intelligence = SetText();
    }
    public void SetWisdom()
    {
        PlayerManager._instance.wisdom = SetText();
    }
    public void SetCharisma()
    {
        PlayerManager._instance.charisma = SetText();
    }



    public int SetText()
    {
        int num;
        int[] rolls = new int[UPPER];
        for (int i = 0; i < UPPER; i++)
        {
            num = rand.Next(1, 5);
            rolls[i] = num;
        }
        Array.Sort(rolls);
        int total = rolls[4] + rolls[5] + rolls[6];
        Textfield.text = "Roll: " + total.ToString();
        return total;
    }
}
