using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida_Inimigo : MonoBehaviour
{
    // Start is called before the first frame update
    public int vidaMaxima=4;
    public int vidaAtual;
    public GameObject Inimigo;
    
    void Start()
    {
        vidaAtual=vidaMaxima;
    }

    // Update is called once per frame
    void Update()
    {
        Saber_vida();
    }
    public void receberDano(int dano){
        vidaAtual-=dano;
    }
    void Saber_vida(){
        if(vidaAtual<=0){
            //Destroi o inimigo especificado logo acima
            Destroy(Inimigo);
        }
    }
    private void OnTriggerEnter2D(Collider2D colisor) {
        Vida_Inimigo enemy=colisor.GetComponent<Vida_Inimigo>();
        if(colisor.gameObject.tag=="Projeteis"){
            receberDano(1);
        }
        Destroy(GameObject.FindWithTag("Projeteis"));
    }
}
