using UnityEngine;
using UnityEngine.UI;


public class JSONOutput : MonoBehaviour
{
    public Text TextField;
    public void getJSON()
    {
        string json = JsonUtility.ToJson(PlayerManager._instance);
        Debug.Log(json);
        TextField.text = json;
        TextEditor te = new TextEditor();
        te.text = json;
        te.SelectAll();
        te.Copy();
        System.IO.File.WriteAllText(Application.persistentDataPath 
                                    + "/CharacterData.json", json);
        Debug.Log(Application.persistentDataPath);
    }
}
