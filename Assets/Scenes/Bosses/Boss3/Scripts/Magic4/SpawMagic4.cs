using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawMagic4 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab;
    public Transform Firepoint;
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
        for(int i = 0; i < 5;i++){
            Vector3 Pocisao=new Vector3(Firepoint.position.x+(i*10),Firepoint.position.y,Firepoint.position.z);
            Instantiate(bulletPrefab,Pocisao,Firepoint.rotation);
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
