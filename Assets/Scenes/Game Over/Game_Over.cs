using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Game_Over : MonoBehaviour
{
    public void Setup(){
        //Quando chamada, ativa a tela de game over
        gameObject.SetActive(true);
    }
    public void Restart(){
        //Ao apertar o botão, ele reinicia a scena, precisa de polimento
        SceneManager.LoadScene("Boss1");
    }
}
