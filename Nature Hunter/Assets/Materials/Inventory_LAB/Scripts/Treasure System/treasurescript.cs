using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class treasurescript : MonoBehaviour
{
    [SerializeField] bool isInteractable;
    //[SerializeField] Animator anim;
    private GameObject treasureHUD;
    public Item[] collectable;

    private void Start()
    {
        treasureHUD = GameObject.Find("HUDManager"); 
        
    }

    private void Update()
    {
        bukaTreasure();
    }

    private void bukaTreasure()
    {
        if(Input.GetButtonDown("Interact"))
        {
            if(isInteractable)
            {
                //anim.SetBool("open", true);
                //treasureHUD.setTreasure(gameObject);
                treasureHUD.GetComponent<TreasureContentUI>().setTreasure(gameObject);
            }
        }
        
    }

    private void OnTriggerStay(Collider other)
    {   
        if(other.tag == "Player")
        {
            Debug.Log("bonus ditemukan");
            isInteractable = true;
            //anim.SetBool("open", true);
        }
        
    }

    private void OnTriggerExit()
    {
        isInteractable = false;
        //anim.SetBool("open", false);
        //treasureHUD.setTreasure(null);
        treasureHUD.GetComponent<TreasureContentUI>().setTreasure(null);
    }
}
