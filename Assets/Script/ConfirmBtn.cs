using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ConfirmBtn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject recipe;
    private SelectController Select;
    void Start()
    {
        recipe = GetComponent<GameObject>();
        Select = GetComponent<SelectController>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*public bool checkRecipe()
    {
        //Select.m_Select.Find(tmp => tmp.m_Name == );
    }*/
}
