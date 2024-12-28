using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static Input;

public class InputReader : ScriptableObject, IPlayerActions
{
    private Input _input;

    private void OnEnable()
    {
        if (_input == null)
        {
            _input = new Input();
        }
        _input.Player.SetCallbacks(this);
        _input.Player.Enable();

    }
    public void OnAction(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnDash(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnRun(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

}
