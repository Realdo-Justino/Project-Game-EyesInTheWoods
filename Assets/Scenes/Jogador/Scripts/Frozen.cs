using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frozen : MonoBehaviour
{
    // Start is called before the first frame update
    Movimentacao Movimentacao;
    FlikerPlayer Fliker;
    SpriteRenderer Sprite;
    Animator Anim;
    void Start()
    {
        Sprite=GetComponent<SpriteRenderer>();
        Movimentacao=GetComponent<Movimentacao>();
        Fliker=GetComponent<FlikerPlayer>();
        Anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool paralisado=Movimentacao.paralisado;
        bool paralisado2=Movimentacao.paralisado2;
        if((paralisado==false)){
            if(Fliker.i==false){
                Sprite.color = Color.white;
            }
        }
        else{
            if(Fliker.i==false){
                if(Sprite.color!=Color.blue) {
                    Sprite.color = Color.blue;
                    Anim.SetBool("Andando",false);
                }
            }
        }
    }
}
