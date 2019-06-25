using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Newtonsoft.Json;

public class Recipe : MonoBehaviour
{
    // Start is called before the first frame update
    
    public List<Recipes> foodRecipe = new List<Recipes>();
    void Start()
    {
        //TextAsset tmp = Resources.Load<TextAsset>("data");
        //Debug.Log(tmp.text);
        //foodRecipe = JsonConvert.DeserializeObject<List<Recipes>>(tmp.text);
        //---------------------------------------------------------------------------
        //
        string json = JsonConvert.SerializeObject(foodRecipe);
        
        Debug.Log(json);
    }
}
[Serializable]
public class Recipes
{
    //Use for set any Detail in Recipe
    public string Menu;
    public List<string> Order;
}
