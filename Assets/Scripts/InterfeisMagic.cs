using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InterfeisMagic : MagicPlayer
{
    public Button skill_Add_Health;
    public Button heal;
    public Button unpoisoned2;
    public Button UnDead;
    public Button Armor;
    public Button Unparalised;
    public Button atck;

    public Scrollbar scrool;
    public GameObject Player;
    public GameObject Enemy;
    private void Start()
    {
        skill_Add_Health.onClick.AddListener(() => Skill_Add_Health(Player.GetComponent<MagicPlayer>().Mana, Player.GetComponent<MagicPlayer>().Max_mana,Player,scrool.value));
        heal.onClick.AddListener(()             => ClearNegativEffects(Player, 20,2));
        unpoisoned2.onClick.AddListener(()      => ClearNegativEffects(Player, 30,3));
        Unparalised.onClick.AddListener(() => ClearNegativEffects(Player, 85, 4));
        UnDead.onClick.AddListener(() => ClearNegativEffects(Player, 150, 5));
        Armor.onClick.AddListener(() => ClearNegativEffects(Player, 50, 6));
        atck.onClick.AddListener(() => Atack(Enemy, 20));
        
    }

    public static void Skill_Add_Health(float mana, float max_mana, GameObject entyte,float amount_of_mana)
    {
        Debug.Log("Heal");
        Debug.Log("Mana"+mana);
        float hel = (mana * amount_of_mana) / 2;
        if (hel <= entyte.GetComponent<Player>().Health)
            entyte.GetComponent<Player>().Health += hel;
        else
            entyte.GetComponent<Player>().Health = hel;
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
                
                entyte.GetComponent<MagicPlayer>().Mana -= amount_of_mana;
                if(effect == 5 || effect == 4)
                {
                    entyte.GetComponent<Player>().Health = 1;
                }
            }
            else
            {
                if (effect == 6)
                    entyte.GetComponent<Player>().Status = 6;
            }
        }
    }

    static void Atack(GameObject target,float damage)
    {
        Debug.Log("Damage"+damage);
        target.GetComponent<Player>().Health -= damage;
    }
   
   







}
