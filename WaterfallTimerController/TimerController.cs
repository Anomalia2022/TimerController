using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Waterfall.EffectControllers;
using Waterfall.UI.EffectControllersUI;

namespace Waterfall
{
    [Serializable]
    [DisplayName("Timer")]
    public class TimerController : WaterfallController
    {
        [Persistent] public float time;
        private float currentTime;

        public TimerController() : base() { }
        public TimerController(ConfigNode node) : base(node) { }

        public override ConfigNode Save()
        {
            var c = base.Save();
            return c;
        }

        public override void Initialize(ModuleWaterfallFX host)
        {
            base.Initialize(host);
            values = new float[1];
            currentTime = time;
        }

        protected override void UpdateInternal()
        {
            if (currentTime > 0)
            {
                currentTime -= Time.deltaTime;
            }
            else
            {
                return; // Time has reached 0, no need to keep setting effect to 0
            }

            values[0] = currentTime / time; // Value from 0-1

        }

    }

}
