using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsPaused=false;
    public GameObject pauseMenuUi;
    public GameObject MusicPlaying;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(GameIsPaused){
                Resume();
            }else{
                Paused();
            }
        }
    }
    public void Resume(){
        pauseMenuUi.SetActive(false);
        MusicPlaying.SetActive(true);
        Time.timeScale=1f;
        GameIsPaused=false;
    }
    void Paused(){
        pauseMenuUi.SetActive(true);
        MusicPlaying.SetActive(false);
        Time.timeScale=0f;
        GameIsPaused=true;
    }
    public void LoadMenu(){
        Time.timeScale=1f;
        SceneManager.LoadScene("Mapa_Teste_2");
    }
    public void QuitGame(){
        Application.Quit();
    }
}
