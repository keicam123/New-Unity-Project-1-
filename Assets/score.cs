using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public playermovement Points;
    public Text st;
    void Update()
    {
        st.text = Points.ToString();
    }
}
