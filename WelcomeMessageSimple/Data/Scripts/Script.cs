using Sandbox.ModAPI;
using VRage.Game.Components;

[MySessionComponentDescriptor(MyUpdateOrder.BeforeSimulation)]
public class WelcomeMod : MySessionComponentBase
{
    private bool _hasWelcomed = false;

    public override void UpdateBeforeSimulation()
    {
        if (!_hasWelcomed && MyAPIGateway.Session != null && MyAPIGateway.Session.LocalHumanPlayer != null)
        {
            string serverName = MyAPIGateway.Session.Name;
            string playerName = MyAPIGateway.Session.LocalHumanPlayer.DisplayName;
            MyAPIGateway.Utilities.ShowMessage("Server", $"Welcome to {serverName}, Engineer ({playerName})!");
            _hasWelcomed = true;
        }
    }
}
