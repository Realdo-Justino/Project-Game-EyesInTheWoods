using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryMagic5 : MonoBehaviour
{
    [SerializeField] Vida_personagem_principal Vida_personagem_principal;
    public GameObject Magic;
    
    // Start is called before the first frame update
    void Start()
    {
        Magic=this.gameObject;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            Vida_personagem_principal.receberDano(1);
        }
         if(other.CompareTag("Blast Zone")){
             Destroy(Magic);
        }
    }
}
