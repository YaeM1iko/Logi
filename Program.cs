using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events;
using Handlers = Exiled.Events.Handlers;
using ConsoleApp6.Handlers;
using ZXCGULSSSPLUSRANK;


namespace Logs
{


    public class HintEvents : Plugin<Config>
    {
        public override PluginPriority Priority => PluginPriority.Medium;

        private Sss neperemenaya;

        private MC c3;

        public override void OnEnabled()
        {
            neperemenaya= new Sss();
            c3 = new MC(neperemenaya);
            base.OnEnabled();
            Handlers.Player.Died += c3.OnPlayerDeath;
            Handlers.Warhead.Detonated += c3.OnWarheadDetonation;
            Handlers.Scp096.Enraging += c3.OnScp096Enrage;
            Handlers.Map.AnnouncingDecontamination += c3.AnnouncingDecontamination;
            Handlers.Map.Decontaminating += c3.Decontaminatig;
            Handlers.Map.GeneratorActivated += c3.GeneratorActivated;
            Handlers.Scp914.Activating += c3.OnScp914Activation;
            Handlers.Scp914.ChangingKnobSetting += c3.OnScp914ChangeKnobSetting;
            Handlers.Map.ExplodingGrenade += c3.OnExplodingGrenade;
            Handlers.Player.ClosingGenerator += c3.Closegenerator;
            Handlers.Player.Shot += c3.Shoot;
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            Handlers.Player.Died -= c3.OnPlayerDeath;
            Handlers.Warhead.Detonated -= c3.OnWarheadDetonation;
            Handlers.Scp049.StartingRecall -= c3.OnCreatingZombie;
            Handlers.Scp096.Enraging -= c3.OnScp096Enrage;
            Handlers.Scp914.Activating -= c3.OnScp914Activation;
            Handlers.Scp914.ChangingKnobSetting -= c3.OnScp914ChangeKnocbSetting;
            Handlers.Map.ExplodingGrenade -= c3.OnExplodingGrenade;
            c3 = null;
            neperemenaya = null;
        }
    }


}