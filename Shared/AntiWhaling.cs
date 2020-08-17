using BepInEx;
using KKAPI.Maker;
using UnityEngine;
using UnityEngine.UI;

namespace AntiWhaling
{
    [BepInPlugin(GUID, PluginName, Version)]
    [BepInDependency("marco.kkapi")]

    public class AntiWhaling : BaseUnityPlugin
    {
        public const string PluginName = "Anti-Whaling";
        public const string GUID = "kky.antiwhaling";
        public const string Version = "0.2.1";

        internal void Start()
        {
            MakerAPI.MakerBaseLoaded += MakerAPI_Enter;
        }
        private void MakerAPI_Enter(object sender, RegisterCustomControlsEvent e)
        {
            GameObject.Find("CanvasSub/SettingWindow/WinBody/B_ShapeBreast/Scroll View/Viewport/Content/SliderSet/Slider").GetComponent<Slider>().maxValue = 0.5f;

        }
    }
}
