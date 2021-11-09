using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida_boss2 : MonoBehaviour
{
    // Start is called before the first frame update
    public int vidaMaxima=30;
    public int vidaAtual;
    [SerializeField] Downword_Chosing Downword_Chosing;
    [SerializeField]Animations Animations;
    [SerializeField]DamageShow DamageShow;
    [SerializeField]Fim_da_fase Fim_da_fase;
    [SerializeField]BoxCollider2D BoxCollider2D;
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
            if(colisor.gameObject.tag=="ProjeteisFortes"){
                receberDano(5);
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
            Fim_da_fase.Finish();
        }
    }
    public void Vuneravel(){
        BoxCollider2D.enabled = true;
        StartCoroutine(ExampleCoroutine(2));
    }
    IEnumerator ExampleCoroutine(float time)
    {
        yield return new WaitForSeconds(time);
        if(vidaAtual>0){
            Downword_Chosing.Starting();
            Animations.ClawingJump=false;
            BoxCollider2D.enabled = false;
            this.enabled=false;
        }
    }
}
