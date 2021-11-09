using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida_Inimigo : MonoBehaviour
{
    // Start is called before the first frame update
    public int vidaMaxima=4;
    public int vidaAtual;
    public GameObject Inimigo;
    SpriteRenderer m_SpriteRenderer;
    
    void Start()
    {
        vidaAtual=vidaMaxima;
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Saber_vida();
    }
    public void receberDano(int dano){
        StartCoroutine(Dano(dano));
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
        if(colisor.gameObject.tag=="ProjeteisFortes"){
            receberDano(5);
        }
        Destroy(GameObject.FindWithTag("Projeteis"));
    }
    IEnumerator Dano(int dano)
    {
        vidaAtual-=dano;
        m_SpriteRenderer.color = Color.red;
        yield return new WaitForSeconds(0.2f);
        m_SpriteRenderer.color = Color.white;
    }
}
