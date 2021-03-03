using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AlignmentSelector : MonoBehaviour
{
    public Text alignmentError;
    public TMP_Dropdown alignmentDropdown;

    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            alignmentError.text = "Please select an alignment";
        }
        else
        {
            alignmentError.text = "";
            alignmentDropdown = GetComponent<TMP_Dropdown>();
            PlayerManager._instance.alignment = alignmentDropdown.options[val].text;
        }
    }
}
