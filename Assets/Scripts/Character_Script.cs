using UnityEngine;
using System.Collections;

public class Character_Script : MonoBehaviour {
    public int HealtPoints;
	public int MaxHealth;
	public int ManaPoints;
	public int MaxMana;
    public int AttackPower;
    public int Defense;
    public int Movement;
    public int AttackRange;
    public int Gold = 0;
	public string spell1;
	public string spell2;
	public string spell3;
	public int spell1cost;
	public int spell2cost;
	public int spell3cost;
	

    //armor and weapons
    public CharacterCard headSlot;
    public CharacterCard chestSlot;
    public CharacterCard leftarmSlot;
    public CharacterCard rightarmSlot;
    public CharacterCard feetSlot;

    public Texture2D charPic;

    public string Ability;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
