using TMPro;
using UnityEngine;

namespace ReusableStateMachine.Runtime
{
    public abstract class StateMachine
    {
        protected StateMachine(IState startState)
        {
            CurrentState = startState;
            CurrentState.Enter();
        }

        protected IState CurrentState { get; private set; }

        /// <summary>
        /// Always call base.Execute()
        /// </summary>
        public virtual void Execute()
        {
            CurrentState.Execute();
        }

        public void LogCurrentState()
        {
            Debug.Log(CurrentState.ToString().Split('.')[^1]);
        }

        public void DisplayCurrentState(TMP_Text text)
        {
            text.text = CurrentState.ToString().Split('.')[^1];
        }

        protected void ChangeState(IState next)
        {
            CurrentState.Exit();
            CurrentState = next;
            CurrentState.Enter();
        }
    }
}