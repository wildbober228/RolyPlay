using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

   static int id_player = 0;
    string name_player;
    enum status
    {
        norm,
        weak,
        ill,
        poisoned,
        paralis,
        dead
    }
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
    int man_woman;
    int age;
    float health;
    float max_health;
    
    int xp;

    public int ID
    {
        get { return id_player; }

        set { id_player = value; }

    }

    private void Start()
    {
        set_id();
        name_player = "Edic";
    }

    private void set_id()
    {
        ID = id_player;
        id_player++;
    }
}
