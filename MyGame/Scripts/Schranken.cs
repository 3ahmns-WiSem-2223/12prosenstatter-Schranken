using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schranken : MonoBehaviour
{

    public GameObject geisel1;
    public GameObject geisel2;
    public GameObject train;
    [SerializeField] private Animator animationTrain;

    public void SaveGeisel1()
    {
        geisel1.SetActive(false);
    }

  
    public void SaveGeisel2()
    {
        geisel2.SetActive(false);
    }

    
    public void Update()
    {
        if (geisel1.activeSelf == false && geisel2.activeSelf == false)
        {
            // train.transform.position = new Vector3(-17f, -2.45f, 0f);
            animationTrain.SetBool("StartAnim", true);
        }
    }

    
}
