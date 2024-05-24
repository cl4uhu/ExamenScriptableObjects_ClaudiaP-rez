using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Items/New Item")]
public class ScriptableItems : ScriptableObject
{
    public enum ItemType
    {
        Weapon,
        Armor
    }

    public ItemType itemType;
    public string itemName;
    public int itemPrice;
    public Sprite itemSprite;
}