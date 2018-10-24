using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InterfeisMagic : MagicPlayer
{
    public Button skill_Add_Health;
    public Button heal;

    public Scrollbar scrool;
    public GameObject Player;
    private void Start()
    {
        skill_Add_Health.onClick.AddListener(() => Skill_Add_Health(Player.GetComponent<MagicPlayer>().Mana, Player.GetComponent<MagicPlayer>().Max_mana,Player,scrool.value));
        heal.onClick.AddListener(() => ClearNegativEffects(Player,20,2));


    }

    public static void Skill_Add_Health(float mana, float max_mana, GameObject entyte,float amount_of_mana)
    {
        Debug.Log("Heal");
        Debug.Log("Mana"+mana);
        entyte.GetComponent<Player>().Health += (mana*amount_of_mana) / 2;
        mana -= (mana * amount_of_mana);
        entyte.GetComponent<MagicPlayer>().Mana = mana;
    }

    public static void ClearNegativEffects(GameObject entyte,float amount_of_mana, int effect)
    {
        if (entyte.GetComponent<MagicPlayer>().Mana >= amount_of_mana)
        {

            if (entyte.GetComponent<Player>().Status == effect)
            {
                Debug.Log("effect clear");
                entyte.GetComponent<Player>().Status = 0;
                entyte.GetComponent<MagicPlayer>().Mana -= 20;
            }
        }
    }

    public static void Heal(GameObject entyte)
    {
        if (entyte.GetComponent<MagicPlayer>().Mana >= 20)
        {
           
            if (entyte.GetComponent<Player>().Status == 2)
            {
                Debug.Log("effect clear");
                entyte.GetComponent<Player>().Status = 0;
                entyte.GetComponent<MagicPlayer>().Mana -= 20;
            }
        }
    }

    public static void UnPoisoned(GameObject entyte)
    {
        if (entyte.GetComponent<MagicPlayer>().Mana >= 30)
        {

            if (entyte.GetComponent<Player>().Status == 3)
            {
                Debug.Log("effect clear");
                entyte.GetComponent<Player>().Status = 0;
                entyte.GetComponent<MagicPlayer>().Mana -= 30;
            }
        }
    }




}
