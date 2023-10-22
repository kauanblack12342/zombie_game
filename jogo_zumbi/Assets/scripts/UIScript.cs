using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Text hpText;
    public playerScript playerScript;
    void Start()
    {
        
    }

    
    void Update()
    {
        hpText.text = GameObject.Find("player").GetComponent<playerScript>().vida.ToString();

       
    }
}
