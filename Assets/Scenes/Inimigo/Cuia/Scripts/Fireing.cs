using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireing : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab;
    public Transform Firepoint;
    void Start()
    {
        RandomNumber();
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
        RandomNumber();
    }
    IEnumerator Waiting(float tempo)
    {
        yield return new WaitForSeconds(tempo);
        Instantiate(bulletPrefab,Firepoint.position,Firepoint.rotation);
        StartCoroutine(Reload()); 
    }
}
