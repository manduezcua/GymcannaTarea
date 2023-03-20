using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class luz : MonoBehaviour
    
{
    [SerializeField]
    
    private Light luces;
    private Slider s;

    // Start is called before the first frame update
    void Start()
    {
        s=transform.GetComponentInChildren<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        luces.intensity= s.value;
    }
}
