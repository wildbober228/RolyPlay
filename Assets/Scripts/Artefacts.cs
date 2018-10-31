using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artefacts : MonoBehaviour
{
  
    bool Can_Use_Before_One;
	public virtual void Life_Water(GameObject entity,int health, ref int amount)
    {
        amount--;
        entity.GetComponent<Player>().Health += health;
    }

    public virtual void Dead_Water(GameObject entity, int mana_amount, ref int amount)
    {
        amount--;
        entity.GetComponent<MagicPlayer>().Mana += mana_amount;
    }

    public virtual void Frogs_Meat(GameObject entity , ref int amount)
    {
        amount--;
        entity.GetComponent<Player>().Status =0;
    }

    public virtual void Poisoned_Teth(GameObject entity, GameObject target,float artefact_force)
    {      if (target.GetComponent<Player>().Status == 0 || target.GetComponent<Player>().Status == 1)
        {
            target.GetComponent<Player>().Status = 3;

            target.GetComponent<Player>().Health -= artefact_force*10;
        }
    }

    public virtual void paralise_eye(GameObject entity, ref int amount)
    {
        amount--;
        if (entity.GetComponent<Player>().Status !=5)
        entity.GetComponent<Player>().Status = 4;
    }

    public virtual void Lighting(GameObject entity,ref float artefact_force_all, float artefact_force_current)
    {
        if (entity.GetComponent<Player>().Status != 5)
        {
            artefact_force_all -= artefact_force_current;
            entity.GetComponent<Player>().Health -= artefact_force_current * 10;
        }

    }

}
