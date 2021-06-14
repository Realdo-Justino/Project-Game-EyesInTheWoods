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
        }else{
            movimento= new Vector3(-1,0,0);
            transform.eulerAngles=new Vector2(0f,0f);
        }
    }
    void PosicaoAtual(){
        Contador+=Time.deltaTime;
        if(Contador>=5){
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
}
