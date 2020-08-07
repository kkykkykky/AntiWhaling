using BepInEx;
using KKAPI.Maker;
using UnityEngine;
using UnityEngine.UI;

namespace HS2_AntiWhaling
{
    [BepInPlugin(GUID, "HS2 Anti-Whaling", Version)]
    [BepInDependency("marco.kkapi")]
    [BepInProcess("HoneySelect2")]

    public class AntiWhaling : BaseUnityPlugin
    {
        public const string GUID = "kky.HS2.antiwhaling";
        public const string Version = "0.1.0";

        internal void Start()
        {
            MakerAPI.MakerBaseLoaded += MakerAPI_Enter;
        }
        private void MakerAPI_Enter(object sender, RegisterCustomControlsEvent e)
        {
            Logger.LogMessage("Anti-Whaling");
            GameObject.Find("CanvasSub/SettingWindow/WinBody/B_ShapeBreast/Scroll View/Viewport/Content/SliderSet/Slider").GetComponent<Slider>().maxValue = 0.5f;

        }
    }
}
