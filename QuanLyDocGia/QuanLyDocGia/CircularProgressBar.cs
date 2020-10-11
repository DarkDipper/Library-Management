using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace BM2
{
    public class CircularProgressBar: Control
    {
        public enum _ProgressShape
        {
            Round,Flat
        }
        public enum _TexTMode
        {
            None,
            Value,
            Percentage,
            Custom
        }
        private long _Value=100;
        private long _Maximum = 100;
        private int _LineWidth = 1;
        private float _BarWidth = 14f;
        private Color _ProgressColor1 = Color.Green;
    }
}
