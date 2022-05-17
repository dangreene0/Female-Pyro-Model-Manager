using System.Collections.Generic;

namespace FemalePyroModelManager
{
    class PaintCheck
    {

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

        public Dictionary<string, string[]> paintsTeam = new Dictionary<string, string[]>()
        {
            {"An Air of Debonair", new string[]{ "#654740", "#28394D"}},
            {"Balaclavas Are Forever", new string[]{ "#3B1F23", "#18233D"}},
            {"Cream Spirit", new string[]{ "#C36C2D", "#B88035"}},
            {"Operator's Overalls", new string[]{ "#483838", "#384248"}},
            {"Team Spirit", new string[]{ "#B8383B", "#5885A2"}},
            {"The Value of Teamwork", new string[]{ "#803020", "#256D8D"}},
            {"Waterlogged Lab Coat", new string[]{ "#A89A8C", "#839FA3"}}
        };
        public string getBasePaint(string paintName)
        {
            string paintVal = "";

            if (paintsBase.ContainsKey(paintName))
            {
                paintVal = paintsBase[paintName];
            }
            return paintVal;
        }
        public string[] getTeamPaint(string paintName)
        {
            string[] paintVal = new string[0];
            if (paintsTeam.ContainsKey(paintName))
            {
                paintVal = paintsTeam[paintName];
            }
            return paintVal;
        }
    }
}
