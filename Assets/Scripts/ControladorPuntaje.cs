using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControladorPuntaje : MonoBehaviour, Observador
{
    public TextMeshProUGUI scorecanva;
    public float Score;

    void Update()
    {
        scorecanva.text = "Score" + Score.ToString();
    }

    public void execute(Sub subject)
    {
        if (subject is GameManager)
        {
            Score = ((GameManager)subject).ScoreA;
        }
    }


}
