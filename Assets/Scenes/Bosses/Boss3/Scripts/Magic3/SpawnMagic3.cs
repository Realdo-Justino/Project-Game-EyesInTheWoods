﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMagic3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab;
    public Transform Firepoint;

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
        Vector3 Pocisao=new Vector3(Firepoint.position.x+10,Firepoint.position.y,Firepoint.position.z);
        Instantiate(bulletPrefab,Pocisao,Firepoint.rotation);
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