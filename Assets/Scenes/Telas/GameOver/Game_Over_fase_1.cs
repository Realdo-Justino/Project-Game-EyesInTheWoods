using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Over_fase_1 : MonoBehaviour
{
    // Start is called before the first frame update
    public void Setup(){
        //Quando chamada, ativa a tela de game over
        gameObject.SetActive(true);
    }
    public void Restart(){
        //Ao apertar o botão, ele reinicia a scena, precisa de polimento
        SceneManager.LoadScene("Mapa_Teste");
    }
}
