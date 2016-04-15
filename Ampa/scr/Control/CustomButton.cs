using System.Drawing;
using System.Windows.Forms;

namespace Ampa.Control
{
    public sealed class CustomButton : Button
    {
        public CustomButton()
        {
            BackColor = Color.FromArgb(0, 127, 255);
          //  Dock = DockStyle.Fill;
            FlatAppearance.BorderColor = Color.FromArgb(255, 255, 255);
            FlatAppearance.BorderSize = 2;
            FlatStyle = FlatStyle.Flat;
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Location = new Point(0, 0);
            Name = "button";
            Size = new Size(117, 39);
            TabIndex = 1;
            UseVisualStyleBackColor = false;
        }

        public override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; }
        }
    }
}