using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class PlayerManager : MonoBehaviour
{

    //[Serializable]
    
    public string playerName;
        
    //Abilities
    public int strength;
    public int dexterity;
    public int constitution;
    public int intelligence;
    public int wisdom;
    public int charisma;

    public string race;
    public string playerClass;
    public string alignment;

    public int maxXp;
    public int currXp;
    public int maxHp;
    public int armorClass;
    public float walkSpeed;
    public float runSpeed;
    public float jumpHeight;

    public List<String> items;
    
    
    public static PlayerManager _instance;
   
    private void Awake()
    {
        
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            _instance = this;
            //player = new Player();

        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}
