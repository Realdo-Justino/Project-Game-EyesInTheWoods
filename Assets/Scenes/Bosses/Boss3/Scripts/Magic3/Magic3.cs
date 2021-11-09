using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic3 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]DamageAcctivator DamageAcctivator;
    [SerializeField]GameObject Magia;

    void Start()
    {
        Begining();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Begining(){
        StartCoroutine(Waiting());
    }
    IEnumerator Waiting(){
        yield return new WaitForSeconds(2);
        DamageAcctivator.Begining();
    }
    public void Comeback(){
        Destroy(Magia);
    }

}
