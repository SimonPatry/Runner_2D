using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JarAmount : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>().text = "0";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SaveJar()
    {
        int JarSaved = PlayerPrefs.GetInt("JarAmount");
        PlayerPrefs.SetInt("JarAmount", JarSaved + int.Parse(gameObject.GetComponent<Text>().text));
    }
}