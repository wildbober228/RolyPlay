using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    

    public InterfeisMagic magicinter;

    static int id_player = 0;
    [SerializeField]
    string name_player;
   
    enum status
    {
        norm,
        weak,
        ill,
        poisoned,
        paralis,
        dead,
        armor
    }
    [SerializeField]
    status stat;
    bool can_speak;
    bool can_go;
   
    enum rasa
    {
        human,
        gnom,
        elf,
        ork,
        goblin
    }
    [SerializeField]
    rasa select_rasa;

    [SerializeField]
    int man_woman;
    int age;
    [SerializeField]
    float health;
    float max_health;
    
    int xp;
    [SerializeField]
    float damage;

    public float Damage
    {
        get { return damage; }

        set { damage = value; }

    }

    public int Status
    {
        get { return (int)stat; }

        set { stat = (status)value; }
    }

    public int ID
    {
        get { return id_player; }

        set { id_player = value; }

    }

    public string Name
    {
        get { return name_player; }

        set { name_player = value; }
    }

    public int Selected_rasa
    {

        get { return (int)select_rasa;  }

        set { select_rasa = (rasa)value; }
    }
    public int Man_woman
    {
        get { return man_woman; }

        set { man_woman = value; }
    }
    public float Health
    {
        get { return health; }

        set { health = value; }
    }

    private void Awake()
    {
        Damage = 20;
        // magicinter.Player = player;
        set_id();
        name_player = "Edic";
       
    }

    private void set_id()
    {
        ID = id_player;
        id_player++;
    }

    


     public void MyUpdate()
    {
        if ( (health *100) / max_health <= 10)
        {
            Status = 1;
        }
        if ((health * 100) / max_health >= 10)
        {
            Status = 0;
        }
        if (health == 0)
        {
            Status = 5;
        }
    }
   
}

/*
 0-norm
 1-weak
 2-ill
 3-poisoned
 4-paralis
 5-dead  
 */
