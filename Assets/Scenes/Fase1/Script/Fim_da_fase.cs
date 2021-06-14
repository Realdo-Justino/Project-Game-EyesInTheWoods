using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fim_da_fase : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]

    string cena;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D colisor) {
        if(colisor.gameObject.CompareTag("Player")){
            SceneManager.LoadScene("Boss1");
        }
        
    }
}
