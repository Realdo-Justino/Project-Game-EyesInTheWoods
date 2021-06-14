using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
public class Titulo : MonoBehaviour
{
    public void Restart(){
        gameObject.SetActive(false);
        SceneManager.LoadScene("Mapa_Teste");
    }
}
