using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Text hpText;
    public Text balasText;
    public playerScript playerScript;
    public Text quantidadeText;

    void Start()
    {
        
    }

    
    void Update()
    {
        hpText.text = GameObject.Find("player").GetComponent<playerScript>().vida.ToString();
        balasText.text = GameObject.Find("player").GetComponent<playerScript>().bulletMax.ToString();

       
    }
}
