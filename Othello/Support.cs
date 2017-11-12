using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Othello
{
    public static class Support
    {
        public static List<UserControl> ucs = new List<UserControl>();

        public static void adduc(UserControl target, Control Container)
        {
            Container.Controls.Add(target);
            ucs.Add(target);
        }

        public static void adduc(UserControl target, Control Container, UserControl currentUc)
        {
            Container.Controls.Add(target);
            ucs.Add(target);
            currentUc.Visible = false;
        }

        public static void back(Control Container,UserControl current)
        {
            if(ucs.Count>0)
            {
                ucs[ucs.Count - 2].Visible = true;
                ucs.RemoveAt(ucs.Count - 1);
            }
        }
    }
}
