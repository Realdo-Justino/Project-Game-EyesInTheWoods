using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic5 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab;
    public Transform Firepoint;
    int contador;
    [SerializeField]PaternProjectiles PaternProjectiles;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RandomNumber(){
        Instantiate(bulletPrefab,Firepoint.position,Firepoint.rotation);
        StartCoroutine(Reload());  
    }
    IEnumerator Reload()
    {
        yield return new WaitForSeconds(1);
        if(contador>=4){
            PaternProjectiles.Doing= false;
            PaternProjectiles.RandomNumber();
            contador=0;
            Debug.Log("Voltei");
        }else{
            contador++;
            RandomNumber();
        }
    }
}
