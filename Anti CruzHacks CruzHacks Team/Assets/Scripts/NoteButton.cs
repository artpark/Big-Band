﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteButton : MonoBehaviour
{
    public bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        //print("hi");
        isActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("Note Enter");
        if (other.gameObject.name == "Note(Clone)") {
            isActive = true;
        }
    }

    private void OnTriggerStay(Collider other) {
        if(Input.GetButtonDown("Fire2"))
        {
            Debug.Log("Hit");
            Destroy(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other) {
        Debug.Log("Note Exit");
        if (other.gameObject.name == "Note(Clone)") {
            isActive = false;
        }
    }
}