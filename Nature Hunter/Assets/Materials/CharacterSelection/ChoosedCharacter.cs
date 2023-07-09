using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosedCharacter : MonoBehaviour
{
    private GameObject[] characterList;

    private int selectedCharacterIndex;

    private void Start()
    {
        selectedCharacterIndex = PlayerPrefs.GetInt("SelectedCharacterIndex");

        // Get the number of children in the transform
        int childCount = transform.childCount;

        // Initialize the characterList array with the correct size
        characterList = new GameObject[childCount];

        // Assign the left and right characters based on the children
        for (int i = 0; i < childCount; i++)
        {
            characterList[i] = transform.GetChild(i).gameObject;

            // Deactivate the character if it's not the selected one
            if (i != selectedCharacterIndex)
            {
                characterList[i].SetActive(false);
            }
        }
    }
}
