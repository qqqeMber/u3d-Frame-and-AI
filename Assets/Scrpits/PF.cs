using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PF : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float a;
        PlayerPrefs.SetFloat("dfsdf", 123);
        a=PlayerPrefs.GetFloat("dfsdf");
        Debug.Log(a);
        PlayerPrefs.Save();
        PlayerPrefs.DeleteKey("dfsdf");
        PlayerPrefs.DeleteAll();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
