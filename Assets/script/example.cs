using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class example : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        for (var i = 0;i<10; i++)
        {
            Instantiate(prefab, new Vector3(i+2.0f,2,0), Quaternion.identity);
        }
    }

    
}
