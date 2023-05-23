using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Sub
{
    void attach(Observador observer);
    void detach(Observador observer);
    void notify();
}
