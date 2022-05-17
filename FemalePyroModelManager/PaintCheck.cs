using System.Collections.Generic;

namespace FemalePyroModelManager
{
    class PaintCheck
    {
        private string paintVal = "";
        public Dictionary<string, string> paintsBase = new Dictionary<string, string>(){
            {"A Color Similar to Slate", "#2F4F4F"},
            {"A Deep Commitment to Purple", "#7D4071"},
            {"A Distinctive Lack of Hue", "#141414"},
            {"A Mann's Mint", "#BCDDB3"},
            {"After Eight", " #2D2D24"},
            {"Aged Moustache Grey", "#7E7E7E"},
            {"An Extraordinary Abundance of Tinge", "#E6E6E6"},
            {"Australium Gold", "#E7B53B"},
            {"Color No. 216-190-216", "#D8BED8"},
            {"Dark Salmon Injustice", "#7D4071"},
            {"Drably Olive", "#808000"},
            {"Indubitably Green", "#729E42"},
            {"Mann Co. Orange", "#CF7336"},
            {"Muskelmannbraun", "#A57545"},
            {"Noble Hatter's Violet", "#51384A"},
            {"Peculiarly Drab Tincture", "#C5AF91"},
            {"Pink as Hell", "#FF69B4"},
            {"Radigan Conagher Brown", "#694D3A"},
            {"The Bitter Taste of Defeat and Lime", "#32CD32"},
            {"The Color of a Gentlemann's Business Pants", "#F0E68C"},
            {"Ye Olde Rustic Colour", "#7C6C57"},
            {"Zepheniah's Greed", "#424F3B"}
        };
        public string getPaint(string paintName)
        {
            if (paintsBase.ContainsKey(paintName))
            {
                paintVal = paintsBase[paintName];
            }
            return paintVal;
        }
    }
}
