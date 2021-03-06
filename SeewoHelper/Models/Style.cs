﻿using Sunny.UI;
using System;

namespace SeewoHelper
{
    class Style
    {
        public delegate void styleChange(object sender, EventArgs e);
        public event styleChange OnStyleChange;
        UIStyle programStyle = UIStyle.LightBlue;
        public UIStyle ProgramStyle
        {
            get
            {
                return programStyle;
            }
            set
            {
                if (programStyle != value)
                {
                    programStyle = value;
                    Program.Logger.Add("切换 Style 为 " + value);
                    OnStyleChange(this, new EventArgs());
                }
                else
                {
                    programStyle = value;
                }
            }
        }
    }
}
