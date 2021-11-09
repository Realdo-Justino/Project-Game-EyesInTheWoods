using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque_Inimigo_Voador : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float Contador;

    [SerializeField]
    float Velocidade;

    [SerializeField]
    bool limite;
    [SerializeField]
    public bool limite2;
    Vector3 movimento=new Vector3(0,0,0);
    void Start()
    {
        
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
            if(limite2==false){
                movimento= new Vector3(1,-1,0);
            }
            else{
                movimento= new Vector3(-1,-1,0);
            }
        }else{
             if(limite2==false){
                movimento= new Vector3(1,1,0);
            }
            else{
                movimento= new Vector3(-1,1,0);
            }
        }
    }
    void PosicaoAtual(){
        Contador+=Time.deltaTime;
        if(Contador>=1){
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
