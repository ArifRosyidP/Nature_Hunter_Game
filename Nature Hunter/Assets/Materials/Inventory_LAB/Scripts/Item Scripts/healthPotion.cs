using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Inventory/HP-Potion")]
public class healthPotion : Item
{
    public float healingAmount, currHealth;
    private int selectedCharacterIndex;

    public override void Use()
    {
        base.Use();
        //tambah darah
        selectedCharacterIndex = PlayerPrefs.GetInt("SelectedCharacterIndex");
        if (selectedCharacterIndex == 1)
        {
            currHealth = PlayerPrefs.GetFloat("darah_Archer");
            currHealth += healingAmount;
            PlayerPrefs.SetFloat("darah_Archer", currHealth);
        }
        else
        {
            currHealth = PlayerPrefs.GetFloat("darah_Axe");
            currHealth += healingAmount;
            PlayerPrefs.SetFloat("darah_Axe", currHealth);
        }
        
        //kurangin dari inventory
        RemoveFromInventory();
    }
}
