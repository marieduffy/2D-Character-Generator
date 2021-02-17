using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var input = gameObject.GetComponent<InputField>();
        var se= new InputField.SubmitEvent();
        se.AddListener(displayText);
        input.onEndEdit = se;

    }

    private void displayText(string textInField)
    {
        Debug.Log(textInField);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
