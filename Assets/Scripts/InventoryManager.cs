using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;

    public ScriptableItems[] weapons;

    public Text[] weaponsNames;
    
    public Text[] weaponsPrices;

    public Image[] weaponsSprites;


    public ScriptableItems[] armor;

    public Text[] armorNames;
    
    public Text[] armorPrices;

    public Image[] armorSprites;


    void Awake()
    {
        instance = this;
    }
    
    public void AddItemWeapon(ScriptableItems item)
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            if(weapons[i] == null)
            {
                weapons[i] = item;
                weaponsNames[i].text = item.itemName;
                weaponsSprites[i].sprite = item.itemSprite;
                weaponsPrices[i].text = item.itemPrice.ToString(); // Asigna el precio del ítem

                return;
            }
        }
    }

    public void AddItemArmor(ScriptableItems item)
    {
        for (int i = 0; i < armor.Length; i++)
        {
            if(armor[i] == null)
            {
                armor[i] = item;
                armorNames[i].text = item.itemName;
                armorSprites[i].sprite = item.itemSprite;
                armorPrices[i].text = item.itemPrice.ToString(); // Asigna el precio del ítem

                return;
            }
        }
    }
}