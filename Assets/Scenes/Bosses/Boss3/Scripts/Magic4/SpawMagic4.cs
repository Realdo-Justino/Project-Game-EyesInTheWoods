using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawMagic4 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab;
    public Transform Firepoint;
    public Transform Firepoint2;
    [SerializeField]PaternProjectiles PaternProjectiles;
    public int contador;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnAtk(){
        contador=0;
        Instantiate(bulletPrefab,Firepoint.position,Firepoint.rotation);
        Instantiate(bulletPrefab,Firepoint2.position,Firepoint.rotation);
        for(int i = 0; i < 6;i++){
            Vector3 Pocisao=new Vector3(Firepoint.position.x,Firepoint.position.y+(i*5),Firepoint.position.z);
            Instantiate(bulletPrefab,Pocisao,Firepoint.rotation);
            Vector3 Pocisao2=new Vector3(Firepoint2.position.x,Firepoint2.position.y+(i*5),Firepoint2.position.z);
            Instantiate(bulletPrefab,Pocisao2,Firepoint.rotation);
            contador++;
        }
        StartCoroutine(Waiting());
    }
    IEnumerator Waiting(){
        yield return new WaitForSeconds(2);
        PaternProjectiles.Doing=false;
        yield return new WaitForSeconds(5);
        PaternProjectiles.RandomNumber();
        PaternProjectiles.Doing=true;
    }
}
