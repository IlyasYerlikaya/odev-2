using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class code : MonoBehaviour
{
    void BolenleriBul(int A, int B)
    {
        A = 1; B = 50;
        int K = 0;
        float[] liste;
        string listestring = "";
        for (int j = 1; j <= 10; j++)
        {
            liste = new float[B / j];
            K = 0;
            listestring = "";
            for (int i = A; i <= B; i++)
            {
                if (i % j == 0)
                {
                    liste[K] = i;
                    K++;
                }
            }
            foreach (float eleman in liste)
            {
                listestring += " " + eleman;
            }
            print(j + " Sayýsýna tam bölünenler: " + listestring);

        }

    }

  
    void Start()
    {
        BolenleriBul(1, 50);

    }


}
