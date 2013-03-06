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
                if (GUI.Button(new Rect(25, 25, 250, 200), TeamCharacters[0].name))
                {
                    DisplayDets = true;
                    charDetails = TeamCharacters[0];
                }
            }
            else
            {
                if (GUI.Button(new Rect(25, 25, 250, 200), "Add New Character"))
                {
                    SelectChar = true;
                    selectTarget = 0;
                }
            }
           
            if (TeamCharacters[1] != null)
            {
                if (GUI.Button(new Rect(500, 25, 250, 200), TeamCharacters[1].name))
                {
                    DisplayDets = true;
                    charDetails = TeamCharacters[1];
                }
            }
            else
            {
                if (GUI.Button(new Rect(500, 25, 250, 200), "Add New Character"))
                {
                    SelectChar = true;
                    selectTarget = 1;
                }
            }
           
            if (TeamCharacters[2] != null)
            {
                if (GUI.Button(new Rect(25, 250, 250, 200), TeamCharacters[2].name))
                {
                    DisplayDets = true;
                    charDetails = TeamCharacters[2];
                }
            }
            else
            {
                if (GUI.Button(new Rect(25, 250, 250, 200), "Add New Character"))
                {
                    SelectChar = true;
                    selectTarget = 2;
                }
            }
            
            if (TeamCharacters[3] != null)
            {
                if (GUI.Button(new Rect(500, 250, 250, 200), TeamCharacters[3].name))
                {
                    DisplayDets = true;
                    charDetails = TeamCharacters[3];
                }
            }
            else
            {
                if (GUI.Button(new Rect(500, 250, 250, 200), "Add New Character"))
                {
                    SelectChar = true;
                    selectTarget = 3;
                }
            }
        }
        else if (!DisplayDets && SelectChar && !openShop)
        {
            if (GUI.Button(new Rect(25, 25, 250, 200), "Archer"))
            {
                TeamCharacters[selectTarget] = Archer;
                SelectChar = false;
            }
            if (GUI.Button(new Rect(500, 25, 250, 200), "Swordsman"))
            {
                TeamCharacters[selectTarget] = Swordsman;
                SelectChar = false;
            }
            if (GUI.Button(new Rect(25, 250, 250, 200), "Spearman"))
            {
                TeamCharacters[selectTarget] = Spearman;
                SelectChar = false;
            }
            if (GUI.Button(new Rect(500, 250, 250, 200), "Mage"))
            {
                TeamCharacters[selectTarget] = Mage;
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
            Character_Script stats = charDetails.transform.GetComponent<Character_Script>();
            string details = charDetails.name + "\n" + "HP: " + stats.HealtPoints.ToString() + "\nAttack: " + stats.AttackPower.ToString()
                                + "\nDefense: " + stats.Defense.ToString() + "\nMovement: " + stats.Movement.ToString() + "\nRange: "
                                + stats.AttackRange.ToString() + "\nHead Item: " + stats.headSlot.ItemName + "\nLeft Hand Item: " + stats.leftarmSlot.ItemName
                                + "\nRight Hand Item: " + stats.rightarmSlot.ItemName + "\nChest Item: " + stats.chestSlot.ItemName + "\nFeet Item: "
                                + stats.feetSlot.ItemName + "\nAbility: " + stats.Ability  + "\nGold: " + stats.Gold;

            if (GUI.Button(new Rect(100, 50, 500, 500), details))
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

            if (GUI.Button(new Rect(650, 350, 150, 150), "Sell Items"))
            {
                openSell = true;
            }
        }
    }
}
