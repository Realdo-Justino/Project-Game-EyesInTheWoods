using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireing : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab;
    public Transform Firepoint;
    [SerializeField]Transform player;
    float alcance_grito;
    Animator animator;
    void Start()
    {
        RandomNumber();
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void RandomNumber(){
        var numero= Random.Range(0.0f, 1.0f);
        StartCoroutine(Waiting(numero));  
    }
    IEnumerator Reload()
    {
        yield return new WaitForSeconds(0.5f);
        animator.SetBool("Atking",false);
        RandomNumber();
    }
    IEnumerator Waiting(float tempo)
    {
        bool result;
        result = ViewDistance();
        if(result ==true){
            yield return new WaitForSeconds(tempo);
            animator.SetBool("Atking",true);
            yield return new WaitForSeconds(0.2f);
            Instantiate(bulletPrefab,Firepoint.position,Firepoint.rotation);
        }
        yield return new WaitForSeconds(0.001f);
        StartCoroutine(Reload()); 
    }
    public bool ViewDistance(){
        bool result=false;
        if(player!=null){
            switch(transform.rotation.y){
                case 1: alcance_grito=transform.position.x-30;
                if(alcance_grito<=player.position.x) result=true;
                else result=false;
                break;
                case 0: alcance_grito=transform.position.x+30;
                if(alcance_grito>=player.position.x) result=true;
                else result=false;
                break;
                default: Debug.Log("Ocorreu um erro");
                Debug.Log(transform.rotation.y);
                break;
            }
        }
        return result;
    }
}
