using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvoqueParticle : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]ParticleSystem ParticleSystem;
    void Start()
    {
        StartCoroutine(Looping());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
            ParticleSystem.Play();
        }
        if(Input.GetKeyDown(KeyCode.O)){
            ParticleSystem.Stop();
        }
    }
    public void Starting(){
        ParticleSystem.Play();
    }
    public void Ending(){
        ParticleSystem.Stop();
    }
    IEnumerator Looping(){
        Starting();
        yield return new WaitForSeconds(10);
        Ending();
        StartCoroutine(Looping());
    }
}
