﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControllerButton : MonoBehaviour {


    public Button start;

    public InputField name;
    public Dropdown rasa;
    public Dropdown pol;

    public GameObject buttleUI;
    public GameObject menuUI;

    public Player player;
	
	void Start () {
        // rasa = GetComponent<Dropdown>();
        start.onClick.AddListener(() => start_game(rasa.value,pol.value,name.text));
      
    }
	
	void start_game(int rasa,int pol, string name)
    {
        player.Selected_rasa = rasa;
        player.Name = name;
        player.Man_woman = pol;

        menuUI.SetActive(true);
        buttleUI.SetActive(true);




    }
}
