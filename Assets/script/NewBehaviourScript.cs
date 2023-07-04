using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NewBehaviourScript: MonoBehaviour
{
    
    public GameObject text;     // Prefab dari teks

        

    void Start()
    {

    }



    void OnTriggerEnter(Collider other)
    {
        // Jika objek lain yang masuk trigger adalah gambar (mesh renderer), aktifkan teks
        if (other.gameObject.tag =="Soekarno")
        {
            text.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Jika objek lain yang keluar dari trigger adalah gambar (mesh renderer), nonaktifkan teks
        if (other.gameObject.tag =="Soekarno")
        {
            text.SetActive(false);
        }
    }
}