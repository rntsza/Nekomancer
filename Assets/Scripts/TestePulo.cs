﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestePulo : MonoBehaviour {

bool podePular = false;
public float forca = 250.0f;
public int duplo = 2;
public Rigidbody2D perso;

void Update()
{
    if (duplo > 0){
        if(Input.GetKeyDown(KeyCode.Space))
        {
        perso.AddForce(new Vector2(0, forca * Time.deltaTime), ForceMode2D.Impulse);
        duplo--;
        }
    }
}
void OnCollisionEnter2D(Collision2D outros)
{
    if (outros.gameObject.CompareTag("plataformas")){
        duplo = 2;
        podePular = true;
    }
}

}