using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScene : MonoBehaviour {

    public GameObject healsBarPlayer;
    public GameObject healsBarEnemy;
    public GameObject manaBarEnemy;
    public GameObject manaBarPlayer;

    public Text manaCost;
    public Text playerEffects;
    public Text enemyEffects;
    public Text eventsLog;

    public Text manaTextPlayer;
    public Text manaTextEnemy;
    public Text healthTextEnemy;
    public Text healthTextPlayer;

    public GameObject Player;
    public GameObject Enemy;

    public Scrollbar Scrol;


	// Use this for initialization
	void Start () {
        manaCost.text = "0";
        playerEffects.text = "";
        enemyEffects.text = "";
        eventsLog.text = "";
    }
	
	void FixedUpdate () {
        manaCost.text = (Player.GetComponent<MagicPlayer>().Mana * Scrol.value).ToString();
        healthTextPlayer.text = Player.GetComponent<MagicPlayer>().Health.ToString();
        manaTextPlayer.text = Player.GetComponent<MagicPlayer>().Mana.ToString();
        healsBarPlayer.transform.localScale = new Vector3((int)(Player.GetComponent<MagicPlayer>().Health / Player.GetComponent<MagicPlayer>().Max_Health), healsBarPlayer.transform.localScale.y, healsBarPlayer.transform.localScale.z);
        manaBarPlayer.transform.localScale = new Vector3(Player.GetComponent<MagicPlayer>().Mana / Player.GetComponent<MagicPlayer>().Max_mana, manaBarPlayer.transform.localScale.y, manaBarPlayer.transform.localScale.z);


        healthTextEnemy.text = Enemy.GetComponent<MagicPlayer>().Health.ToString();
        manaTextEnemy.text = Enemy.GetComponent<MagicPlayer>().Mana.ToString();


        healsBarEnemy.transform.localScale = new Vector3((int)(Enemy.GetComponent<MagicPlayer>().Health / Enemy.GetComponent<MagicPlayer>().Max_Health), healsBarEnemy.transform.localScale.y, healsBarEnemy.transform.localScale.z);
        manaBarEnemy.transform.localScale = new Vector3(Enemy.GetComponent<MagicPlayer>().Mana / Enemy.GetComponent<MagicPlayer>().Max_mana, manaBarEnemy.transform.localScale.y, manaBarEnemy.transform.localScale.z);
    }
}
