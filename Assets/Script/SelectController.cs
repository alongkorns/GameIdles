using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectController : MonoBehaviour
{
    public List<string> m_Select;

    string m_Order = "";

    public void InpInputBnt(string name)
    {
        if (m_Order != null)
        {
            m_Order = name;
            m_Select.Add(m_Order);
        }
            
    }

}
