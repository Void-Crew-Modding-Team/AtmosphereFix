using VoidManager.MPModChecks;

namespace AtmosphereFix
{
    public class VoidManagerPlugin : VoidManager.VoidPlugin
    {
        public override MultiplayerType MPType => MultiplayerType.Host;

        public override string Author => "18107";

        public override string Description => "Synchronises O2 and pressure";
    }
}
