using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDmanagerBeruang : MonoBehaviour
{

    [SerializeField] GameObject pausemenu;
    [SerializeField] GameObject KonfirmasiSave;
    [SerializeField] GameObject KonfirmasiExit;
    private bool GameIsPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShowPauseMenu();
    }

    private void ShowPauseMenu()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pausemenu.SetActive(false);
        GameIsPaused = false;
        KonfirmasiSave.SetActive(false);
        KonfirmasiExit.SetActive(false);
        // Cursor.lockState = CursorLockMode.Locked;
    }

    void Pause()
    {
        pausemenu.SetActive(true);
        GameIsPaused = true;
        KonfirmasiSave.SetActive(false);
        KonfirmasiExit.SetActive(false);
        // Cursor.lockState = CursorLockMode.Confined;
    }


    public void ExitGame()
    {
        KonfirmasiExit.SetActive(true);
        KonfirmasiSave.SetActive(false);
        
    }

    public void SaveGame()
    {
        KonfirmasiSave.SetActive(true);
        KonfirmasiExit.SetActive(false);
    }

    public void KonfirmaSaveGameYES()
    {
         Debug.Log("GAME DISIMPAN");
         KonfirmasiSave.SetActive(false);
    }

    public void KonfirmaSaveGameNO()
    {
        KonfirmasiSave.SetActive(false);
    }


    public void KonfirmaExitGameNO()
    {
        KonfirmasiExit.SetActive(false);
    }
}
