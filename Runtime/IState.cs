namespace ReusableStateMachine.Runtime
{
    public interface IState
    {
        void Enter();
        void Exit();
        void Execute();
    }
}