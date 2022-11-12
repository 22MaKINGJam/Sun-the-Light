using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeEffect : MonoBehaviour
{

    Text tx;
    AudioSource bgm;
    private string Msg = "";
    int done = 0;

    void Start()
    {
        tx = GetComponent<Text>();
        Msg = tx.text;
        StartCoroutine(_typing());
    }

    void Update()
    {
        if (done == 1)
        {
            bgm = GetComponent<AudioSource>();
            bgm.mute = true;
            done = 0;
        }
    }

    IEnumerator _typing()
    {
        for (int i = 0; i <= Msg.Length; i++)
        {
            tx.text = Msg.Substring(0, i);
            if (i == Msg.Length)
                done = 1;
            yield return new WaitForSeconds(0.05f);
        }
    }

}
