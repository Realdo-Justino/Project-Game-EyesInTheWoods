using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vision : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform player;
    [SerializeField] Transform inimigo;
    [SerializeField] float visao;
    public float pulo=0;
    public bool near=false;
    // Update is called once per frame
    void Start(){
        Checks();
    }
    void Checks(){
        if(player!=null){
            float distanciaPlayer=Vector2.Distance(inimigo.position,player.position);
            if(distanciaPlayer<=visao){
                near =true;
            }
            else{
                near =false;
            }
            if(transform.position.x<player.position.x){
                pulo=10;
            }
            else{
                pulo=-10;
            }
            StartCoroutine(Waiting());
        }
    }
    IEnumerator Waiting(){
        yield return new WaitForSeconds(0.2f);
        Checks();
    }
}
