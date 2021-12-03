using System.Collections;
using System.Collections.Generic;
using FSMImplementation;
using UnityEngine;

public class MachineTest : MonoBehaviour
{
    void Start()
    {
        var machine = new GumballMachine(3);
        machine.InsertACoin();
        machine.InsertACoin();
        machine.TakeReward();
        machine.EjectACoin();
        machine.TurnCrank();
        machine.EjectACoin();
        
    }

}
