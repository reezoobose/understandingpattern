using UnityEngine;

namespace Script.State_Pattern
{
    public class StateMachineTest : MonoBehaviour
    {
        private StateMachine _machine;
        private bool _gameStarted;
        private bool _released = true;

        private void Update()
        {
            if (Input.GetKey(KeyCode.Space) && !_gameStarted && _released)
            {
                _machine = new StateMachine();
                _gameStarted = true;
                Debug.Log("Game Started .");
                _released = false;
            }
            if (Input.GetKey(KeyCode.R) && _released) _machine.Run();
            if (Input.GetKey(KeyCode.F) && _released) _machine.Fly();
            if (Input.GetKey(KeyCode.E) && _released)
            {
                _gameStarted = false;
                Debug.Log("Game over .");
            }

            if (Input.anyKey) _released = false;
            if (!Input.anyKey) _released = true;
            
        }
    }
}