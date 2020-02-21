using UnityEngine;

public class InputButton : MonoBehaviour
{
    public static float VerticalInput;

    public enum State
    {
        None,
        Down,
        Up
    }

    private State state = State.None;

    private void Update()
    {
        switch (state)
        {
            case State.None:
                VerticalInput = 0f;
                break;
            case State.Up:
                VerticalInput = 1f;
                break;
            case State.Down:
                VerticalInput = -1f;
                break;
        }
    }

    public void OnMoveUpButtonPressed()
    {
        state = State.Up;
    }

    public void OnMoveUpButtonUp()
    {
        if(state == State.Up)
        {
            state = State.None;
        }
    }

    public void OnMoveDownButtonPressed()
    {
        state = State.Down;
    }

    public void OnMoveDownButtonUp()
    {
        if(state == State.Down)
        {
            state = State.None;
        }
    }
}