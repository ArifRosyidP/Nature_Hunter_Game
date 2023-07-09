
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CharacterChooser : MonoBehaviour
{
    public GameObject[] characterList;
    private int selectedIndex = 0;

    void Start()
    {
        characterList = new GameObject[2];

        // Assign the left and right characters
        characterList[0] = transform.GetChild(0).gameObject;
        characterList[1] = transform.GetChild(1).gameObject;

        // Show both characters initially
        characterList[0].SetActive(true);
        characterList[1].SetActive(true);
    }

    public void SelectCharacter(int characterIndex)
    {
        selectedIndex = characterIndex;
        PlayerPrefs.SetInt("SelectedCharacterIndex", selectedIndex);

        // Deactivate the unselected character
        int unselectedIndex = 1 - selectedIndex;
        characterList[unselectedIndex].SetActive(false);

        // Do something with the selected character, such as saving the index for the next scene

        // Trigger the transition to the next scene
        StartCoroutine(LoadNextScene());
    }

    IEnumerator LoadNextScene()
    {
        // Wait for a short delay to ensure the player sees the selected character
        yield return new WaitForSeconds(1f);

        // Load the next scene
        SceneManager.LoadScene("SelectDifficulty");
    }


}
