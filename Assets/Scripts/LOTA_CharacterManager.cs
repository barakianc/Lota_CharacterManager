using UnityEngine;
using System.Collections;

public class LOTA_CharacterManager : MonoBehaviour {
    public GameObject[] TeamCharacters = new GameObject[4];
    private GameObject charDetails;
    private bool DisplayDets = false;
    private bool SelectChar = false;
    private bool openShop = false;
    private bool openSell = false;
    private CharacterCard boughtItemhead;
    private CharacterCard boughtItemLhand;
    private CharacterCard boughtItemRhand;
    private CharacterCard boughtItemChest;
    private CharacterCard boughtItemFeet;
    public CharacterCard[] ShopCards;
    private int selectTarget;
    public GameObject Archer;
    public GameObject Swordsman;
    public GameObject Mage;
    public GameObject Spearman;
    public string charname = "Character Name";
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        if (!DisplayDets && !SelectChar && !openShop)
        {
            if (TeamCharacters[0] != null)
            {
				string charinfo = TeamCharacters[0].name + "\nHP: " + TeamCharacters[0].GetComponent<Character_Script>().HealtPoints + 
					"\nMP: " + TeamCharacters[0].GetComponent<Character_Script>().ManaPoints + "\nAttack: " + TeamCharacters[0].GetComponent<Character_Script>().AttackPower
						+ "\nDefense: " + TeamCharacters[0].GetComponent<Character_Script>().Defense + "\n Movement: " + TeamCharacters[0].GetComponent<Character_Script>().Movement
						+ "\nRange: " + TeamCharacters[0].GetComponent<Character_Script>().AttackRange;
					
                if (GUI.Button(new Rect(125, 25, 250, 200),charinfo ))
                {
                    DisplayDets = true;
                    charDetails = TeamCharacters[0];
                }
				//damage
				if(GUI.Button(new Rect(50,25,75,75),"Damage 1")){
					TeamCharacters[0].GetComponent<Character_Script>().HealtPoints--;
					if(TeamCharacters[0].GetComponent<Character_Script>().HealtPoints < 0){
						TeamCharacters[0].GetComponent<Character_Script>().HealtPoints = TeamCharacters[0].GetComponent<Character_Script>().MaxHealth;
					}
				}
				//heal
				if(GUI.Button(new Rect(50,100,75,75),"Heal 1")){
					if(TeamCharacters[0].GetComponent<Character_Script>().HealtPoints < TeamCharacters[0].GetComponent<Character_Script>().MaxHealth){
						TeamCharacters[0].GetComponent<Character_Script>().HealtPoints++;
					}
					
				}
				//restore
				if(GUI.Button(new Rect(50,175,75,50),"MP +1")){
					if(TeamCharacters[0].GetComponent<Character_Script>().ManaPoints < TeamCharacters[0].GetComponent<Character_Script>().MaxMana){
						TeamCharacters[0].GetComponent<Character_Script>().ManaPoints++;
					}
					
				}
				//Spell1
				if(GUI.Button(new Rect(375,25,75,75),TeamCharacters[0].GetComponent<Character_Script>().spell1)){
					if(TeamCharacters[0].GetComponent<Character_Script>().ManaPoints >= TeamCharacters[0].GetComponent<Character_Script>().spell1cost ){
						TeamCharacters[0].GetComponent<Character_Script>().ManaPoints -= TeamCharacters[0].GetComponent<Character_Script>().spell1cost;
					}
				}
				//spell2
				if(GUI.Button(new Rect(375,100,75,75),TeamCharacters[0].GetComponent<Character_Script>().spell2)){
					if(TeamCharacters[0].GetComponent<Character_Script>().ManaPoints >= TeamCharacters[0].GetComponent<Character_Script>().spell2cost ){
						TeamCharacters[0].GetComponent<Character_Script>().ManaPoints -= TeamCharacters[0].GetComponent<Character_Script>().spell2cost;
					}
					
				}
				//spell3
				if(GUI.Button(new Rect(375,175,75,50),TeamCharacters[0].GetComponent<Character_Script>().spell3)){
					if(TeamCharacters[0].GetComponent<Character_Script>().ManaPoints >= TeamCharacters[0].GetComponent<Character_Script>().spell3cost ){
						TeamCharacters[0].GetComponent<Character_Script>().ManaPoints -= TeamCharacters[0].GetComponent<Character_Script>().spell3cost;
					}
					
				}
            }
            else
            {
                if (GUI.Button(new Rect(125, 25, 250, 200), "Add New Character"))
                {
                    SelectChar = true;
                    selectTarget = 0;
                    charname = "Character Name";
                }
            }
           
            if (TeamCharacters[1] != null)
            {
				string charinfo = TeamCharacters[1].name + "\nHP: " + TeamCharacters[1].GetComponent<Character_Script>().HealtPoints + 
					"\nMP: " + TeamCharacters[1].GetComponent<Character_Script>().ManaPoints + "\nAttack: " + TeamCharacters[1].GetComponent<Character_Script>().AttackPower
						+ "\nDefense: " + TeamCharacters[1].GetComponent<Character_Script>().Defense + "\n Movement: " + TeamCharacters[1].GetComponent<Character_Script>().Movement
						+ "\nRange: " + TeamCharacters[1].GetComponent<Character_Script>().AttackRange;
                if (GUI.Button(new Rect(575, 25, 250, 200), charinfo))
                {
                    DisplayDets = true;
                    charDetails = TeamCharacters[1];
                }
				if(GUI.Button(new Rect(500,25,75,75),"1 Damage")){
					TeamCharacters[1].GetComponent<Character_Script>().HealtPoints--;
					if(TeamCharacters[1].GetComponent<Character_Script>().HealtPoints < 0){
						TeamCharacters[1].GetComponent<Character_Script>().HealtPoints = TeamCharacters[1].GetComponent<Character_Script>().MaxHealth;
					}
				}
				if(GUI.Button(new Rect(500,100,75,75),"Heal 1")){
					if(TeamCharacters[1].GetComponent<Character_Script>().HealtPoints < TeamCharacters[1].GetComponent<Character_Script>().MaxHealth){
						TeamCharacters[1].GetComponent<Character_Script>().HealtPoints++;
					}
					
				}
				if(GUI.Button(new Rect(500,175,75,50),"MP +1")){
					if(TeamCharacters[1].GetComponent<Character_Script>().ManaPoints < TeamCharacters[1].GetComponent<Character_Script>().MaxMana){
						TeamCharacters[1].GetComponent<Character_Script>().ManaPoints++;
					}
					
				}
				//Spell1
				if(GUI.Button(new Rect(825,25,75,75),TeamCharacters[1].GetComponent<Character_Script>().spell1)){
					if(TeamCharacters[1].GetComponent<Character_Script>().ManaPoints >= TeamCharacters[1].GetComponent<Character_Script>().spell1cost ){
						TeamCharacters[1].GetComponent<Character_Script>().ManaPoints -= TeamCharacters[1].GetComponent<Character_Script>().spell1cost;
					}
				}
				//spell2
				if(GUI.Button(new Rect(825,100,75,75),TeamCharacters[1].GetComponent<Character_Script>().spell2)){
					if(TeamCharacters[1].GetComponent<Character_Script>().ManaPoints >= TeamCharacters[1].GetComponent<Character_Script>().spell2cost ){
						TeamCharacters[1].GetComponent<Character_Script>().ManaPoints -= TeamCharacters[1].GetComponent<Character_Script>().spell2cost;
					}
					
				}
				//spell3
				if(GUI.Button(new Rect(825,175,75,50),TeamCharacters[1].GetComponent<Character_Script>().spell3)){
					if(TeamCharacters[1].GetComponent<Character_Script>().ManaPoints >= TeamCharacters[1].GetComponent<Character_Script>().spell3cost ){
						TeamCharacters[1].GetComponent<Character_Script>().ManaPoints -= TeamCharacters[1].GetComponent<Character_Script>().spell3cost;
					}
					
				}
            }
            else
            {
                if (GUI.Button(new Rect(575, 25, 250, 200), "Add New Character"))
                {
                    SelectChar = true;
                    selectTarget = 1;
                    charname = "Character Name";
                }
            }
           
            if (TeamCharacters[2] != null)
            {
				string charinfo = TeamCharacters[2].name + "\nHP: " + TeamCharacters[2].GetComponent<Character_Script>().HealtPoints + 
					"\nMP: " + TeamCharacters[2].GetComponent<Character_Script>().ManaPoints + "\nAttack: " + TeamCharacters[2].GetComponent<Character_Script>().AttackPower
						+ "\nDefense: " + TeamCharacters[2].GetComponent<Character_Script>().Defense + "\n Movement: " + TeamCharacters[2].GetComponent<Character_Script>().Movement
						+ "\nRange: " + TeamCharacters[2].GetComponent<Character_Script>().AttackRange;
                if (GUI.Button(new Rect(125, 250, 250, 200), charinfo))
                {
                    DisplayDets = true;
                    charDetails = TeamCharacters[2];
                }
				if(GUI.Button(new Rect(50,250,75,75),"1 Damage")){
					TeamCharacters[2].GetComponent<Character_Script>().HealtPoints--;
					if(TeamCharacters[2].GetComponent<Character_Script>().HealtPoints < 0){
						TeamCharacters[2].GetComponent<Character_Script>().HealtPoints = TeamCharacters[2].GetComponent<Character_Script>().MaxHealth;
					}
				}
				if(GUI.Button(new Rect(50,325,75,75),"Heal 1")){
					if(TeamCharacters[2].GetComponent<Character_Script>().HealtPoints < TeamCharacters[2].GetComponent<Character_Script>().MaxHealth){
						TeamCharacters[2].GetComponent<Character_Script>().HealtPoints++;
					}
					
				}
				if(GUI.Button(new Rect(50,400,75,50),"MP +1")){
					if(TeamCharacters[2].GetComponent<Character_Script>().ManaPoints < TeamCharacters[2].GetComponent<Character_Script>().MaxMana){
						TeamCharacters[2].GetComponent<Character_Script>().ManaPoints++;
					}
					
				}
				//Spell1
				if(GUI.Button(new Rect(375,250,75,75),TeamCharacters[2].GetComponent<Character_Script>().spell1)){
					if(TeamCharacters[2].GetComponent<Character_Script>().ManaPoints >= TeamCharacters[2].GetComponent<Character_Script>().spell1cost ){
						TeamCharacters[2].GetComponent<Character_Script>().ManaPoints -= TeamCharacters[2].GetComponent<Character_Script>().spell1cost;
					}
				}
				//spell2
				if(GUI.Button(new Rect(375,325,75,75),TeamCharacters[2].GetComponent<Character_Script>().spell2)){
					if(TeamCharacters[2].GetComponent<Character_Script>().ManaPoints >= TeamCharacters[2].GetComponent<Character_Script>().spell2cost ){
						TeamCharacters[2].GetComponent<Character_Script>().ManaPoints -= TeamCharacters[2].GetComponent<Character_Script>().spell2cost;
					}
					
				}
				//spell3
				if(GUI.Button(new Rect(375,400,75,50),TeamCharacters[2].GetComponent<Character_Script>().spell3)){
					if(TeamCharacters[2].GetComponent<Character_Script>().ManaPoints >= TeamCharacters[2].GetComponent<Character_Script>().spell3cost ){
						TeamCharacters[2].GetComponent<Character_Script>().ManaPoints -= TeamCharacters[2].GetComponent<Character_Script>().spell3cost;
					}
					
				}
            }
            else
            {
                if (GUI.Button(new Rect(125, 250, 250, 200), "Add New Character"))
                {
                    SelectChar = true;
                    selectTarget = 2;
                    charname = "Character Name";
                }
            }
            
            if (TeamCharacters[3] != null)
            {
				string charinfo = TeamCharacters[3].name + "\nHP: " + TeamCharacters[3].GetComponent<Character_Script>().HealtPoints + 
					"\nMP: " + TeamCharacters[3].GetComponent<Character_Script>().ManaPoints + "\nAttack: " + TeamCharacters[3].GetComponent<Character_Script>().AttackPower
						+ "\nDefense: " + TeamCharacters[3].GetComponent<Character_Script>().Defense + "\n Movement: " + TeamCharacters[3].GetComponent<Character_Script>().Movement
						+ "\nRange: " + TeamCharacters[3].GetComponent<Character_Script>().AttackRange;
                if (GUI.Button(new Rect(575, 250, 250, 200), charinfo))
                {
                    DisplayDets = true;
                    charDetails = TeamCharacters[3];
                }
				if(GUI.Button(new Rect(500,250,75,75),"1 Damage")){
					TeamCharacters[3].GetComponent<Character_Script>().HealtPoints--;
					if(TeamCharacters[3].GetComponent<Character_Script>().HealtPoints < 0){
						TeamCharacters[3].GetComponent<Character_Script>().HealtPoints = TeamCharacters[3].GetComponent<Character_Script>().MaxHealth;
					}
				}
				if(GUI.Button(new Rect(500,325,75,75),"Heal 1")){
					if(TeamCharacters[3].GetComponent<Character_Script>().HealtPoints < TeamCharacters[3].GetComponent<Character_Script>().MaxHealth){
						TeamCharacters[3].GetComponent<Character_Script>().HealtPoints++;
					}
					
				}
				if(GUI.Button(new Rect(500,400,75,50),"MP +1")){
					if(TeamCharacters[3].GetComponent<Character_Script>().ManaPoints < TeamCharacters[3].GetComponent<Character_Script>().MaxMana){
						TeamCharacters[3].GetComponent<Character_Script>().ManaPoints++;
					}
					
				}
				//Spell1
				if(GUI.Button(new Rect(825,250,75,75),TeamCharacters[3].GetComponent<Character_Script>().spell1)){
					if(TeamCharacters[3].GetComponent<Character_Script>().ManaPoints >= TeamCharacters[3].GetComponent<Character_Script>().spell1cost ){
						TeamCharacters[3].GetComponent<Character_Script>().ManaPoints -= TeamCharacters[3].GetComponent<Character_Script>().spell1cost;
					}
				}
				//spell2
				if(GUI.Button(new Rect(825,325,75,75),TeamCharacters[3].GetComponent<Character_Script>().spell2)){
					if(TeamCharacters[3].GetComponent<Character_Script>().ManaPoints >= TeamCharacters[3].GetComponent<Character_Script>().spell2cost ){
						TeamCharacters[3].GetComponent<Character_Script>().ManaPoints -= TeamCharacters[3].GetComponent<Character_Script>().spell2cost;
					}
					
				}
				//spell3
				if(GUI.Button(new Rect(825,400,75,50),TeamCharacters[3].GetComponent<Character_Script>().spell3)){
					if(TeamCharacters[3].GetComponent<Character_Script>().ManaPoints >= TeamCharacters[3].GetComponent<Character_Script>().spell3cost ){
						TeamCharacters[3].GetComponent<Character_Script>().ManaPoints -= TeamCharacters[3].GetComponent<Character_Script>().spell3cost;
					}
					
				}
            }
            else
            {
                if (GUI.Button(new Rect(575, 250, 250, 200), "Add New Character"))
                {
                    SelectChar = true;
                    selectTarget = 3;
                    charname = "Character Name";
                }
            }
			//new turn mana upkeep
			if(GUI.Button(new Rect((Screen.width/2)-75,Screen.height-125,150,100),"New Turn")){
				for(int i = 0; i < 4; i++){
					if(TeamCharacters[i] != null){
						if(TeamCharacters[i].GetComponent<Character_Script>().ManaPoints < TeamCharacters[i].GetComponent<Character_Script>().MaxMana){
							TeamCharacters[i].GetComponent<Character_Script>().ManaPoints++;
						}
					}
				}
			}
        }
        else if (!DisplayDets && SelectChar && !openShop)
        {
            
            charname = GUI.TextArea(new Rect(400, 150, 150, 50), charname,200);
            if (GUI.Button(new Rect(125, 25, 250, 200), "Ranger:\nA quick range character\n with great mobility with\n the ability to stun and launch\n Multiple attacks."))
            {
                TeamCharacters[selectTarget] = (GameObject)Instantiate(Archer,transform.position, transform.rotation);
                if (charname == "" || charname == "Character Name")
                    TeamCharacters[selectTarget].name = "Ranger P" + (selectTarget + 1).ToString();
                else
                    TeamCharacters[selectTarget].name = charname;
                SelectChar = false;
            }
            if (GUI.Button(new Rect(575, 25, 250, 200), "Swordsman:\nA Tank type character with\n high health and Defense\n that can and hold the line during battle"))
            {
                TeamCharacters[selectTarget] = (GameObject)Instantiate(Swordsman, transform.position, transform.rotation);
                if (charname == "" || charname == "Character Name")
                    TeamCharacters[selectTarget].name = "Swordsman P" + (selectTarget + 1).ToString();
                else
                    TeamCharacters[selectTarget].name = charname;
                SelectChar = false;
            }
            if (GUI.Button(new Rect(125, 250, 250, 200), "Spearman:\nA well balanced character\nthat can use his abilities to close\n the gap on other players"))
            {
                TeamCharacters[selectTarget] = (GameObject)Instantiate(Spearman,transform.position, transform.rotation);
                if (charname == "" || charname == "Character Name")
                    TeamCharacters[selectTarget].name = "Spearman P" + (selectTarget + 1).ToString();
                else
                    TeamCharacters[selectTarget].name = charname;
                SelectChar = false;
            }
            if (GUI.Button(new Rect(575, 250, 250, 200), "Mage:\nA fragile but powerful range attacker\n with the ability to use mana\n to empower their attacks"))
            {
                TeamCharacters[selectTarget] = (GameObject)Instantiate(Mage, transform.position, transform.rotation);
                if (charname == "" || charname == "Character Name")
                    TeamCharacters[selectTarget].name = "Mage P" + (selectTarget + 1).ToString();
                else
                    TeamCharacters[selectTarget].name = charname;
                SelectChar = false;
            }
        }
        else if (DisplayDets && !SelectChar && openShop)
        {
            string[] selStrings = new string[] { "Boots of Speed: +1 to movement", "Boots of Speed: +1 to movement", 
                                                "Boots of Speed: +1 to movement", "Boots of Speed: +1 to movement" };
            int selGridInt = 0;
            selGridInt = GUILayout.SelectionGrid(selGridInt, selStrings, 2);

            if (GUI.Button(new Rect(700, 500, 75, 75), "Exit Shop"))
            {
                openShop = false;
            }
        }
        else
        {
			GUIStyle newstyle = new GUIStyle(GUI.skin.button);
			newstyle.alignment = TextAnchor.MiddleLeft;
            Character_Script stats = charDetails.transform.GetComponent<Character_Script>();
            string details = charDetails.name + "\n" + "HP: " + stats.HealtPoints.ToString() + "\nAttack: " + stats.AttackPower.ToString()
                                + "\nDefense: " + stats.Defense.ToString() + "\nMovement: " + stats.Movement.ToString() + "\nRange: "
                                + stats.AttackRange.ToString() + "\nAbilitys\n" + stats.Ability1 + "\n" + stats.Ability1ln2 
								+ "\n" + stats.Ability2 + "\n" + stats.Ability2ln2 + "\n" + stats.Ability3 + "\n" + stats.Ability3ln2;

            if (GUI.Button(new Rect(100, 50, 500, 500), details,newstyle))
            {
                DisplayDets = false;
            }

            if(GUI.Button(new Rect( 650, 50,150,150),"Add Kill!")){
                stats.Gold += 3;
            }

            if (GUI.Button(new Rect(650, 200, 150, 150), "Buy Items"))
            {
                openShop = true;
            }

            if (GUI.Button(new Rect(650, 350, 150, 150), "Delete Character"))
            {
				Destroy(charDetails);
                DisplayDets = false;
            }
        }
    }
}
