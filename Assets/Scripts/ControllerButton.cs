using System.Collections;
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
    public Text username;
    public Text enemyName;
    public Player player;
    public InterfeisMagic magic;
    public GameObject inventori_UI;
    public Button inventori;

    public Artefacts artefacts;
    [Header("Stats")]
    public Text stats;
    /// <summary>
    /// /buttons inventri
    /// </summary>
    /// 
    [Header("Inventori")]
    public Button Life_Water_B;
    public int Amount_Life_Water;
    public Text Life_Water_T;



    void Start () {
        // rasa = GetComponent<Dropdown>();
        start.onClick.AddListener(() => start_game(rasa.value,pol.value,name.text));
        inventori.onClick.AddListener(() => Inventori_Show());
        Life_Water_B.onClick.AddListener
            (()=> 
        {
            if (Amount_Life_Water > 0)
            {
                artefacts.Life_Water(magic.Player, 25, ref Amount_Life_Water);
                Life_Water_T.text = Amount_Life_Water.ToString();
                player.MyUpdate();
                Update_Buttons();
            }
        });
        Update_Buttons();
    }
	
	void start_game(int rasa,int pol, string name)
    {
        player.Selected_rasa = rasa;
        player.Name = name;
        username.text = name;
        player.Man_woman = pol;

        buttleUI.SetActive(true);
        username.text = name;
        enemyName.text = "Уичтожитель всего сущего 3000";
        
        menuUI.SetActive(false);
    }

    void Inventori_Show()
    {
        buttleUI.SetActive(!buttleUI.activeSelf);
        inventori_UI.SetActive(!buttleUI.activeSelf);
    }

    void Update_Buttons()
    {
        Life_Water_T.text = Amount_Life_Water.ToString();
       set_stats(player.Status);
    }

    void set_stats(int type)
    {
        switch (type)
        {
            case 0:
                stats.text = "Normal";
                break;
            case 1:
                stats.text = "Weakness";
                break;
            case 2:
                stats.text = "Ill";
                break;
            case 3:
                stats.text = "Poisoned";
                break;
            case 4:
                stats.text = "Paralise";
                break;
            case 5:
                stats.text = "Dead";
                break;
            case 6:
                stats.text = "Armor";
                break;

        }
       
    }
   
}
