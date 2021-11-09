using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao_Inimigo_Voador : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    float Velocidade;

    [SerializeField]
    bool limite;

    [SerializeField]
    float Contador;
    Vector3 movimento=new Vector3(0,0,0);

    [SerializeField]
    Ataque_Inimigo_Voador Ataque_Inimigo_Voador;
    void Start()
    {
        Debug.Log("Calmo");
    }

    // Update is called once per frame
    void Update()
    {
        EstadoCalmo();
        
    }

    void EstadoCalmo(){
        PosicaoAtual();
        transform.position+=Velocidade*Time.deltaTime*movimento;
    }
    void Lado(){
        if(limite==false){
            movimento= new Vector3(1,0,0);
            transform.eulerAngles=new Vector2(0f,180f);
            Ataque_Inimigo_Voador.limite2=true;
        }else{
            movimento= new Vector3(-1,0,0);
            transform.eulerAngles=new Vector2(0f,0f);
            Ataque_Inimigo_Voador.limite2=false;
        }
    }
    void PosicaoAtual(){
        Contador+=Time.deltaTime;
        if(Contador>=4){
            switch(limite){
                case false:
                    limite=true;
                    Contador=0;
                    break;
                case true: 
                    limite=false;
                    Contador=0;
                    break;
            }
        }
        Lado();
    }
    private void OnTriggerEnter2D(Collider2D colisor) {
        if(colisor.gameObject.CompareTag("Player")){
            colisor.gameObject.GetComponent<Vida_personagem_principal>().receberDano(1);
        }
        
    }
}
