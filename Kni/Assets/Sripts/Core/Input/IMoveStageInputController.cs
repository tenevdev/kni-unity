namespace Assets.Sripts.Core.Input
{
    public interface IMoveStageInputController
    {
        event StoneSelectedEventHandler StoneSelected;
        event DestinationSelectedEventHandler DestinationSelected;
    }

    public delegate void StoneSelectedEventHandler(IMoveStageInputController sender, StoneSelectedEventArgs args);
    public delegate void DestinationSelectedEventHandler(IMoveStageInputController sender, PositionSelectedEventArgs args);
}