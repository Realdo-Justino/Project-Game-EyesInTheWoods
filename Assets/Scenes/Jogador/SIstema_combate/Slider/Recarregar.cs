using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recarregar : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public float Incremento;
    private float currentValue = 0f;
    public float CurrentValue {
    get {
        return currentValue;
    }
    set {
        currentValue = value;
        slider.value = currentValue;
    }
    
}
    void Start()
    {
        CurrentValue = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        CurrentValue += Incremento*Time.deltaTime;
    }
}
