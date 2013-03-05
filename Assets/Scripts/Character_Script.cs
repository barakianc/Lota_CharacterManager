using UnityEngine;
using System.Collections;

public class Character_Script : MonoBehaviour {
    public int HealtPoints;
    public int AttackPower;
    public int Defense;
    public int Movement;
    public int AttackRange;
    public int Gold = 0;

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
