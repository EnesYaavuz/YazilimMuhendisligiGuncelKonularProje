// Bu script, balonların davranışlarını ve patlama mekanizmasını yönetir.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kod_Balon : MonoBehaviour
{    
    float hiz;
    public static float minHiz = 0.5f;
    public static float maxHiz = 2f;
    void Start()
    {
        RenkDegistir();

        HizDegistir();
    }

    void Update()
    {
        transform.Translate(Vector3.back * hiz * Time.deltaTime);

        if (transform.position.y > 8)
        {
            // Can eksilt
            Camera.main.GetComponent<Kod_Arayuz_BalonPatlatma>().CanMiktariGuncelle(-1);

            Destroy(this.gameObject);
        }
    }

    private void OnMouseDown() 
    {
        // patlama sesi eklenecek
        // balonun patlatildigini haber ver
        Camera.main.GetComponent<Kod_Arayuz_BalonPatlatma>().BalonPatlatildi();

        Destroy(this.gameObject);
    }

    void RenkDegistir()
    {
        this.GetComponent<Renderer>().material.color = Random.ColorHSV(); 
    }

    void HizDegistir()
    {
         hiz = Random.Range(minHiz, maxHiz);
    }
}
