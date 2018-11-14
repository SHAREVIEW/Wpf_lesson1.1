using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wpf_lesson1._4_GUI_About
{
    //保存Option窗口各值的属性
    [Serializable]
    public class GameOptions
    {
        public bool PlayerAgainstComputer { get; set; }
        public int NumberOfPlayers { get; set; }
        public int MinutesBeforeLoss { get; set; }
        public ComputerSkillLevel ComputerSkill { get; set; }
    }
    [Serializable]
    public enum ComputerSkillLevel   //枚举Level
    {
        Dumb, Good, Cheats
    }
}
