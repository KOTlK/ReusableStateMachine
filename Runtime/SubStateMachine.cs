namespace ReusableStateMachine.Runtime
{
    public class SubStateMachine : StateMachine, IState
    {
        protected SubStateMachine(IState startState) : base(startState)
        {
        }

        public virtual void Enter()
        {
        }

        public virtual void Exit()
        {
        }
    }
}