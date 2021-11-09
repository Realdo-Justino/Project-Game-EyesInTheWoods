using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab;
    public GameObject bulletPrefab2;
    public Transform Firepoint;
    int contador;
    [SerializeField]PaternProjectiles PaternProjectiles;
    void Start(){

    }
    void Update(){

    }
    
    public void RandomNumber(){
        Chose();
        if(gameObject.activeInHierarchy==false){
            Debug.Break(); 
        }
        StartCoroutine(Reload());  
    }
    IEnumerator Reload()
    {
        yield return new WaitForSeconds(1);
        if(contador>=4){
            PaternProjectiles.Doing= false;
            PaternProjectiles.RandomNumber();
            contador=0;
        }else{
            RandomNumber();
        }
    }
    void Chose(){
        var numero= Random.Range(1.0f, 2.0f);
        int Inumero=Mathf.RoundToInt(numero);
        switch(Inumero){
                case 1: Instantiate(bulletPrefab,Firepoint.position,Firepoint.rotation);
                break;
                case 2: Instantiate(bulletPrefab2,Firepoint.position,Firepoint.rotation);
                break;
        }
        contador++;
    }
}
