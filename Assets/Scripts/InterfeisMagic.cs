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
        skill_Add_Health.onClick.AddListener(() => Skill_Add_Health(Player.GetComponent<MagicPlayer>().Mana, Max_mana,Player,scrool.value));
        heal.onClick.AddListener(()             => ClearNegativEffects(Player, 20, 2));
        unpoisoned2.onClick.AddListener(()      => ClearNegativEffects(Player, 30, 3));
        Unparalised.onClick.AddListener(()      => ClearNegativEffects(Player, 85, 4));
        UnDead.onClick.AddListener(()           => ClearNegativEffects(Player,150, 5));
        Armor.onClick.AddListener(()            => ClearNegativEffects(Player, 50, 6));
        atck.onClick.AddListener(()             => Atack(Enemy, 20));
        
    }

    public static void Skill_Add_Health(float mana, float max_mana, GameObject entyte,float amount_of_mana)
    {
        Debug.Log("Heal");
        Debug.Log("Mana"+mana);
        float hel = (mana * amount_of_mana) / 2;
        Player p = entyte.GetComponent<Player>();
        if (mana != 0)
        {
            if (hel <= p.Health)
                p.Health += hel;
            else
                p.Health = hel;
            mana -= (mana * amount_of_mana);
            entyte.GetComponent<MagicPlayer>().Mana = mana;
        }
    }

    public static void ClearNegativEffects(GameObject entyte,float amount_of_mana, int effect)
    {
        Player p = entyte.GetComponent<Player>();
        if (entyte.GetComponent<MagicPlayer>().Mana >= amount_of_mana)
        {

            if (p.Status == effect && p.Status!=6)
            {
                Debug.Log("effect clear");
               
                p.Status = 0;
                
                entyte.GetComponent<MagicPlayer>().Mana -= amount_of_mana;
                if(effect == 5 || effect == 4)
                {
                    p.Health = 1;
                }
            }
            else
            {
                if (effect == 6 && p.Status==0)
                    p.Status = 6;
            }
        }
    }

    public static void Atack(GameObject target,float damage)
    {
        Player p = target.GetComponent<Player>();
        Debug.Log("Damage"+damage);
        p.Health -= damage;
    }
   
   







}
