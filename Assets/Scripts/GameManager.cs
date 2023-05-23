using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour , Sub
{
    public static GameManager instance;

    private int score = 0;

    private List<Observador> observers;

    public int Score;

    public int ScoreA { get { return Score; } }


    void Awake()
    {
        observers = new List<Observador>();
        instance = this;
    }
    public static GameManager getInstance()
    {
        return instance;
    }
    public void Update()
    {

        notify();
    }

    public void Button1()
    {
        Score = 1;
    }
    public void Button2()
    {
        Score = 2;
    }
    public void Button3()
    {
        Score = 3;
    }

    public void attach(Observador observer)
    {
        observers.Add(observer);
    }

    public void detach(Observador observer)
    {
        observers.Remove(observer);
    }

    public void notify()
    {
        foreach (Observador observer in observers)
        {
            observer.execute(this);
        }
    }
}
