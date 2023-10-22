using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class diretorSctipt : MonoBehaviour
{
    public cameraScript fpsCam;
    public GameObject gameOver;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        fpsCam.body.localEulerAngles = new Vector3(0, 0, 0);
        fpsCam.transform.localEulerAngles = new Vector3(0, 0, 0);
        gameOver.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void reiniciar()
    {
        
        SceneManager.LoadScene("SampleScene");
        gameOver.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1f;
    }
}
