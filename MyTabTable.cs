using System;
using System.Windows.Forms;

namespase System.Windows.Forms
{
    public class MyTabTable
    {
        // TableLayoutPanelCellPosition{ControlsActors, ControlSlider, Control{Controls}}
        public static void Slider(object sender, Control slider, Control page)
        {
            TableLayoutPanelCellPosition cellPosition;
            if (sender is Control _sender)
                if (_sender.Parent is TableLayoutPanel table)
                {
                    cellPosition = table.GetCellPosition(_sender);
                    cellPosition.Row++;
                    table.SetCellPosition(slider, cellPosition);
                }
            View(page);
        }
        
        // Control{Controls}
        public static void View(Control control)
        {
            foreach (Control _control in control.Parent.Controls)
                _control.Visible = false;
            control.Visible = true;
            control.Dock = DockStyle.Fill;
        }
    }
}
