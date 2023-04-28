using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events;
using Exiled.Events.Handlers;
using PlayerApi = Exiled.Events.Handlers.Player;
namespace Logs
    public class HintEvents : Plugin<Config>
    {       
        public override PluginPriority Priority => PluginPriority.Medium;

        private EventHandlers eventHandlers;

        public override void OnEnabled()
        {
            base.OnEnabled();
            eventHandlers = new EventHandlers();
            PlayerApi.Died += eventHandlers.OnPlayerDeath;
            Exiled.Events.Handlers.Warhead.Detonated += eventHandlers.OnWarheadDetonation;
            Exiled.Events.Handlers.Server.RoundStarted += eventHandlers.OnRoundStarted;
            Exiled.Events.Handlers.Scp049.CreatingZombie += eventHandlers.OnCreatingZombie;
            Exiled.Events.Handlers.Scp096.Enraging += eventHandlers.OnScp096Enrage;
            Exiled.Events.Handlers.Scp914.Activating += eventHandlers.OnScp914Activation;
            Exiled.Events.Handlers.Scp914.ChangingKnobSetting += eventHandlers.OnScp914ChangeKnobSetting;
            Exiled.Events.Handlers.Server.SendingConsoleCommand += eventHandlers.OnSendingConsoleCommand;
            Exiled.Events.Handlers.Map.ExplodingGrenade += eventHandlers.OnExplodingGrenade;
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            Exiled.Events.Handlers.Player.Died -= eventHandlers.OnPlayerDeath;
            Exiled.Events.Handlers.Warhead.Detonated -= eventHandlers.OnWarheadDetonation;
            Exiled.Events.Handlers.Server.RoundStarted -= eventHandlers.OnRoundStarted;
            Exiled.Events.Handlers.Scp049.CreatingZombie -= eventHandlers.OnCreatingZombie;
            Exiled.Events.Handlers.Scp096.Enraging -= eventHandlers.OnScp096Enrage;
            Exiled.Events.Handlers.Scp914.Activating -= eventHandlers.OnScp914Activation;
            Exiled.Events.Handlers.Scp914.ChangingKnobSetting -= eventHandlers.OnScp914ChangeKnobSetting;
            Exiled.Events.Handlers.Server.SendingConsoleCommand -= eventHandlers.OnSendingConsoleCommand;
            Exiled.Events.Handlers.Map.ExplodingGrenade -= eventHandlers.OnExplodingGrenade;
            eventHandlers = null;
        }
    }

    public class EventHandlers
    {
        public void OnPlayerDeath(PlayerDeathEventArgs ev)
        {
            string deathMessage = ev.HitInformation.GetDeathMessage();
            foreach (Player player in Player.List)
            {
                if (!player.IsDead)
                {
                    player.ShowHint(deathMessage, 10f);
                }
            }
        }

       