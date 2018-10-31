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
    public Scrollbar slider_force_magic;
     [Header("Life_Water")]
    public Button Life_Water_B;
    public int Amount_Life_Water;
    public Text Life_Water_T;

    [Header("Dead_Water")]
    public Button Dead_Water_B;
    public int Amount_Dead_Water;
    public Text Dead_Water_T;
    [Header("Frogs_Meat")]
    public Button Frogs_Meat_B;
    public int Amount_Frogs_Meat;
    public Text Frogs_Meat_T;
    [Header("Poisoned_Teth")]
    public Button Poisoned_Teth_B;
    public float Force_Poisoned_Teth;
    public Text Poisoned_Teth_T;
    [Header("paralise_eye")]
    public Button paralise_eye_B;
    public int Amount_paralise_eye;
    public Text paralise_eye_T;
    public GameObject Enemy;
    [Header("paralise_eye")]
    public Button Lighting_B;
    public float Force_Lighting_all;
    public Text Lighting_T;
    void Start () {
        // rasa = GetComponent<Dropdown>();
        start.onClick.AddListener(() => start_game(rasa.value,pol.value,name.text));
        inventori.onClick.AddListener(() => Inventori_Show());
        Life_Water_B.onClick.AddListener
        (()=> 
        {
            if (Amount_Life_Water > 0 && player.Status !=5)
            {
                artefacts.Life_Water(magic.Player, 25, ref Amount_Life_Water);
                Life_Water_T.text = Amount_Life_Water.ToString();
                player.MyUpdate();
                Update_Buttons();
            }
        });
        Dead_Water_B.onClick.AddListener
        (() =>
        {
            if (Amount_Dead_Water > 0 && player.Status != 5)
            {
                artefacts.Dead_Water(magic.Player, 25, ref Amount_Dead_Water);
                Dead_Water_T.text = Amount_Dead_Water.ToString();
                player.MyUpdate();
                Update_Buttons();
            }
        });
        Frogs_Meat_B.onClick.AddListener
      (() =>
      {
          if (Amount_Frogs_Meat > 0 && player.Status != 5)
          {
              artefacts.Frogs_Meat(magic.Player, ref Amount_Frogs_Meat);
              Frogs_Meat_T.text = Amount_Frogs_Meat.ToString();
              player.MyUpdate();
              Update_Buttons();
          }
      });
        Poisoned_Teth_B.onClick.AddListener
 (() =>
 {
     if (player.Status != 5)
     {
         Force_Poisoned_Teth = slider_force_magic.value;
         artefacts.Poisoned_Teth(magic.Player, Enemy, Force_Poisoned_Teth);
         Poisoned_Teth_T.text = Force_Poisoned_Teth.ToString();
         player.MyUpdate();
         Update_Buttons();
     }
 });
        paralise_eye_B.onClick.AddListener
 (() =>
 {
     if (Amount_paralise_eye > 0 && player.Status == 5)
     {
        
         artefacts.paralise_eye(magic.Player,ref Amount_paralise_eye);
         paralise_eye_T.text = Amount_paralise_eye.ToString();
         player.MyUpdate();
         Update_Buttons();
     }
 });
        Lighting_B.onClick.AddListener
(() =>
{
if (player.Status != 5 && Force_Lighting_all >0)
{

        artefacts.Lighting(Enemy, ref Force_Lighting_all, slider_force_magic.value);
        Lighting_T.text = Force_Lighting_all.ToString();
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
        enemyName.text = "Уничтожитель всего сущего 3000";
        
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
        Dead_Water_T.text = Amount_Dead_Water.ToString();
        Poisoned_Teth_T.text = Force_Poisoned_Teth.ToString();
        paralise_eye_T.text = Amount_paralise_eye.ToString();
        Frogs_Meat_T.text = Amount_Frogs_Meat.ToString();
        Lighting_T.text = Force_Lighting_all.ToString();
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
