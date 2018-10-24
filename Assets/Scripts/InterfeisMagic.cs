using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfeisMagic : MonoBehaviour
{
    public static void Skill_Add_Health(float Mana, float Max_mana, float Force_magic, GameObject entyte)
    {
        entyte.GetComponent<Player>().Health = Mana / 2;
    }
}
