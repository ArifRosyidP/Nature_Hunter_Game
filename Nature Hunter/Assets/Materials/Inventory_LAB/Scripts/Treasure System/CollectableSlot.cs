using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableSlot : MonoBehaviour
{   
    public Text textnya;
    public Button buttonnya;
    [SerializeField] Item item;
    [SerializeField] treasurescript TargetTreasure;
    [SerializeField] GameObject ContentParent;
    int index;

    public void ItemAdded(Item newItem, treasurescript _targetTreasure, int i)
    {
        if(newItem == null)
        {
            item = null;
            textnya.text = null;
            buttonnya.interactable = false;
            TargetTreasure = null;
            index = 0;
            
        }
        else
        {
            item = newItem;
            textnya.text = item.name;
            buttonnya.interactable = true;
            TargetTreasure = _targetTreasure;
            index = i;
        }
        
    }

    public void ItemCollected()
    {
        if(Inventory.instance.Add(item))
        {
            TargetTreasure.collectable[index] = null;
            Debug.Log(item.name + " collected.");
            item = null;
            textnya.text = null;
            buttonnya.interactable = false;
            index = 0;

            TargetTreasure.gameObject.SetActive(false);
            ContentParent.SetActive(false);

        }
        
    }
}