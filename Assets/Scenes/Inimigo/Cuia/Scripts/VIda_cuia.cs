using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VIda_cuia : MonoBehaviour
{
    // Start is called before the first frame update
    public int vidaMaxima=5;
    public int vidaAtual;
    public GameObject Inimigo;
    [SerializeField]DamageShow DamageShow;
    void Start()
    {
        vidaAtual=vidaMaxima;
    }

    // Update is called once per frame
    void Update()
    {
        Saber_vida();
    }
    void OnTriggerEnter2D(Collider2D colisor) {
        if(this.enabled==true){
            if(colisor.gameObject.tag=="Projeteis"){
                receberDano(1);
            }
            Destroy(GameObject.FindWithTag("Projeteis"));
        }
    }
    public void receberDano(int dano){
        vidaAtual-=dano;
        DamageShow.ShowDamage();
    }
    void Saber_vida(){
        if(vidaAtual<=0){
            //Destroi o inimigo especificado logo acima
            Destroy(Inimigo);
        }
    }
}
