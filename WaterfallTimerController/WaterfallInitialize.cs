using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Waterfall.UI;

namespace Waterfall
{
    [KSPAddon(KSPAddon.Startup.Instantly, false)]
    public class WaterfallInitialize : MonoBehaviour
    {
        public bool firstLoad = true;
        public static WaterfallInitialize Instance { get; private set; }

        protected void Awake()
        {
            Instance = this;
        }

        public static void ModuleManagerPostLoad()
        {
            UIResources.InitalizeUIResources();
        }

    }
}
