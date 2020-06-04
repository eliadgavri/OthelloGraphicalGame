﻿using System.Windows.Forms;

namespace Ex05_Othelo
{
    // $G$ CSS-999 (-3) class name should start with Button
    public class GameButton : Button
    {
        private int m_X;
        private int m_Y;

        internal int X
        {
            get
            {
                return m_X;
            }

            set
            {
                m_X = value;
            }
        }

        internal int Y
        {
            get
            {
                return m_Y;
            }

            set
            {
                m_Y = value;
            }
        }
    }
}
