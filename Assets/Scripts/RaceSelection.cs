using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class RaceSelection : MonoBehaviour
{
    // Start is called before the first frame update
    public Text RaceErrorText;
    public string myRace;
    public TMP_Dropdown raceDropdown;
    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            RaceErrorText.text = "Please select a race";
        }
        else
        {
            RaceErrorText.text = "";
            raceDropdown = GetComponent<TMP_Dropdown>();
            myRace = raceDropdown.options[val].text;
            //Debug.Log("Race = " + myRace);
            PlayerManager._instance.race = myRace;
        }
    }

    
}
