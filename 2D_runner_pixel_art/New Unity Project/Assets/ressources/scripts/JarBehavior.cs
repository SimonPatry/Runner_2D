using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JarBehavior : MonoBehaviour
{
    public int value = 1;
    private GameObject UI;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        UI = GameObject.FindGameObjectWithTag("JarAmount");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            int jarUI = int.Parse(UI.GetComponent<Text>().text) + value;
            UI.GetComponent<Text>().text = jarUI + "";
            animator.SetBool("IsCollect", true);
        }
    }
}
