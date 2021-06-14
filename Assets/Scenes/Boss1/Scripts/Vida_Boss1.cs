using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida_Boss1 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    int estado;

    [SerializeField]
    int vidaAtual=10;

    public GameObject Boss;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Saber_vida();
    }
    void Saber_vida(){
        if(vidaAtual<=0){
            //Destroi o inimigo especificado logo acima
            Destroy(Boss);
            Debug.Log("Morri");
        }
    }

    void receberDano(int dano){
        vidaAtual-=dano;
    }
    private void OnTriggerEnter2D(Collider2D colisor) {
        
        if(colisor.gameObject.tag=="Projeteis"){
            receberDano(1);
        }
    }
}
