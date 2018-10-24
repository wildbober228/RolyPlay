using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicPlayer : Player
{
    [SerializeField]
    private float mana;
    [SerializeField]
    private float max_mana;

    private int force_magic;
    
    
   public float Mana
   {
        get { return mana; }

        set { mana = value; }
    }

    public float Max_mana
    {
        get { return max_mana; }

        set { max_mana = value; }

    }

    private void Awake()
    {
        Max_mana = 5000;
        Mana = 5000;
    }



}
