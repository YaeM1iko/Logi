
using Exiled.Events.EventArgs.Map;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.EventArgs.Scp096;
using Exiled.Events.EventArgs.Scp914;
using Exiled.Events.EventArgs.Scp049;
using ZXCGULSSSPLUSRANK;

namespace ConsoleApp6.Handlers
{
    public class MC
    {
        public int OnSendingConsoleCommand { get; internal set; }

        private Sss peremenaya;

        public MC(Sss peremenaya) {this.peremenaya= peremenaya;} 

        public void OnPlayerDeath(DiedEventArgs ev)
        {
            peremenaya.AddHint($"Челик {ev.Player.Nickname} Умир");
        }

        public void GeneratorActivated(GeneratorActivatedEventArgs ev)
        {
            peremenaya.AddHint("Генератор вкл");
        }

        public void OnWarheadDetonation()
        {
            peremenaya.AddHint("КАбум");
        }

        public void OnScp096Enrage(EnragingEventArgs ev)
        {
            peremenaya.AddHint("BEZIT");
        }

         public void AnnouncingDecontamination(AnnouncingDecontaminationEventArgs ev)
        {
            peremenaya.AddHint("ANONS декома");
        }

         public void Decontaminatig(DecontaminatingEventArgs ev)
        {
            peremenaya.AddHint("START");
        }

        public void OnScp914Activation(ActivatingEventArgs ev)
        {
            peremenaya.AddHint("Активация 914");
        }

        public void OnScp914ChangeKnobSetting(ChangingKnobSettingEventArgs ev)
        {
            peremenaya.AddHint("Вращение рычага");
        }

        public void OnExplodingGrenade(ExplodingGrenadeEventArgs ev)
        {
            peremenaya.AddHint("Подрыв ачка");
        }

        public void OnCreatingZombie(StartingRecallEventArgs ev)
        {
            peremenaya.AddHint("Поднимает чурку");
        }

        public void OnScp914ChangeKnocbSetting(ChangingKnobSettingEventArgs ev)
        {
            peremenaya.AddHint("дергает");
        }

        public void Closegenerator(ClosingGeneratorEventArgs ev)
        {
            peremenaya.AddHint($"{nameof(Closegenerator)}");
        }

        public void Shoot(ShotEventArgs ev)
        {
            peremenaya.AddHint("стрельба");
        }
    }
}
