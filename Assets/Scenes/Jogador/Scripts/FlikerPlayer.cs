using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Threading.Tasks;

public class FlikerPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer Sprite;
    float contador=0;
    public bool i=false;
    Movimentacao Movimentacao;
    void Start()
    {
        Sprite=GetComponent<SpriteRenderer>();
        Movimentacao=GetComponent<Movimentacao>();
        contador=Time.deltaTime;
        FLiker();
    }
    void Update(){
        if(i==true){
            contador++;
            if(contador>299){
                i=false;
                contador=0;
            }
        }
    }
    void FLiker(){
        if(i==true){
            StartCoroutine(Waiting(0.08f));
        }else ChangeBack();
    }
    IEnumerator ReDo(float time){
        yield return new WaitForSeconds(time);
        FLiker();
    }
    IEnumerator Waiting(float time){
        Sprite.color = Color.clear;
        yield return new WaitForSeconds(time);
        Sprite.color = Color.white;
        yield return new WaitForSeconds(time);
        StartCoroutine(ReDo(time));
    }
    void ChangeBack(){
        if(Movimentacao.paralisado==false) Sprite.color = Color.white;
        StartCoroutine(ReDo(0.1f));
    }

}
