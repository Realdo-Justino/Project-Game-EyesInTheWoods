using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoss : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab;
    public Transform Firepoint;
    public int contador;
    void Start()
    {
        Instantiate(bulletPrefab,Firepoint.position,Firepoint.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
