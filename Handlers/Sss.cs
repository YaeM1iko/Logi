using Exiled.API.Features;
using MEC;
using System.Collections.Generic;

namespace ZXCGULSSSPLUSRANK
{
    public class Sss
    {
        private readonly Queue<string> ZXC = new Queue<string>();

        private bool IsShowing = false;

        public void AddHint(string hint)
        {
            ZXC.Enqueue(hint);

            if (IsShowing) return;

            ShowHint();
        }

        private void ShowHint()
        {
            if (ZXC.TryDequeue(out var message))
            {
                Map.ShowHint($"<size=35><color=#0000FF><alpha=#AA>{message}</color></size>");

                IsShowing = true;

                Timing.CallDelayed(3f, () =>
                {
                    IsShowing = false;
                    ShowHint();
                });
            }
        }
    }
}