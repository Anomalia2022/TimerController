using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Waterfall.UI.EffectControllersUI
{
    public class TimerControllerUIOptions : DefaultEffectControllerUIOptions<TimerController>
    {
        private readonly string[] timerString = new string[1];
        private float timer;

        public TimerControllerUIOptions() { }

        public override void DrawOptions()
        {
            GUILayout.Label("Time");
            GUILayout.BeginHorizontal();
            GUILayout.Label("Time", UIResources.GetStyle("data_header"), GUILayout.MaxWidth(160f));
            timerString[0] = GUILayout.TextArea(timerString[0], GUILayout.MaxWidth(60f));
            var newTime = 0f;
            if (Single.TryParse(timerString[0], out float timeParse))
            {
                newTime = timeParse;
            }
            if(newTime != timer)
            {
                timer = newTime;
            }

            GUILayout.EndHorizontal();
        }

        protected override void LoadOptions(TimerController controller)
        {
            timerString[0] = controller.time.ToString();

        }

        protected override TimerController CreateControllerInternal() =>
          new TimerController()
          {
            time = timer
          };

    }
}