using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMagic3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab;
    public Transform Firepoint;
    public Transform Firepoint2;

    [SerializeField]PaternProjectiles PaternProjectiles;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnAtk(){
        Instantiate(bulletPrefab,Firepoint.position,Firepoint.rotation);
        Instantiate(bulletPrefab,Firepoint2.position,Firepoint.rotation);
        Vector3 Pocisao=new Vector3(Firepoint2.position.x+10,Firepoint2.position.y,Firepoint2.position.z);
        Vector3 Pocisao2=new Vector3(Firepoint2.position.x+20,Firepoint2.position.y,Firepoint2.position.z);
        Instantiate(bulletPrefab,Pocisao,Firepoint.rotation);
        Instantiate(bulletPrefab,Pocisao2,Firepoint.rotation);
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
