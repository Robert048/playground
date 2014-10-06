using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// int click -> bool clicks
namespace dsm
{
    class ConnectManager
    {
        int clicks;
        object parent;
        Control parentControl;
        bool connectToolSelected;

        public ConnectManager()
        {
            clicks = 0;
        }

        public void panel_Click(object sender, EventArgs e)
        {
            if (connectToolSelected && !sender.Equals(parentControl)) {
                //Machine is clicked
                if (sender is Panel && (sender as Control).Tag is DataTemplate) {
                    if (clicks == 0) {
                        parentControl = (sender as Control);
                        parent = (sender as Control).Tag as DataTemplate;
                        clicks++;
                    }
                    else if (clicks == 1) {
                        if ((sender as Panel).Tag is Calculator) {
                            ((sender as Panel).Tag as Calculator).setParent(parent);
                        }
                        else if ((sender as Panel).Tag is IfOperator) {
                            ((sender as Panel).Tag as IfOperator).setParent(parent);
                        }
                        else if ((sender as Panel).Tag is WarningSettings) {
                            ((sender as Panel).Tag as WarningSettings).setParent(parent);
                        }
                        clicks = 0;
                        parentControl = null;
                        parent = null;
                    }
                }
                //Label on Machine is clicked
                else if (sender is Label && (sender as Control).Parent.Tag is DataTemplate) {
                    Panel panel = (sender as Label).Parent as Panel;
                    if (clicks == 0) {
                        parent = (sender as Control).Tag as DataTemplate;
                        clicks++;
                    }
                    else if (clicks == 1) {
                        if (panel.Tag is Calculator) {
                            (panel.Tag as Calculator).setParent(parent);
                        }
                        else if (panel.Tag is IfOperator) {
                            (panel.Tag as IfOperator).setParent(parent);
                        }
                        else if (panel.Tag is WarningSettings) {
                            (panel.Tag as WarningSettings).setParent(parent);
                        }
                        clicks = 0;
                        parentControl = null;
                        parent = null;
                    }
                }
                //Calculator, IfOperator or Warning is clicked
                else if (sender is Panel && (sender as Control).Tag is Form) {
                    Panel panel = sender as Panel;
                    if (clicks == 0) {
                        parent = ((sender as Control).Tag as Calculator).getOutput();
                        clicks++;
                    }
                    else if (clicks == 1) {
                        if (panel.Tag is Calculator) {
                            (panel.Tag as Calculator).setParent(parent);
                        }
                        else if (panel.Tag is IfOperator) {
                            (panel.Tag as IfOperator).setParent(parent);
                        }
                        else if (panel.Tag is WarningSettings) {
                            (panel.Tag as WarningSettings).setParent(parent);
                        }
                        clicks = 0;
                        parentControl = null;
                        parent = null;
                    }
                }
                //Label on Calculator, IfOperator or Warning is clicked
                else if (sender is Label && (sender as Control).Parent.Tag is Form) {
                    Panel panel = (sender as Label).Parent as Panel;
                    if (clicks == 0) {
                        parent = ((sender as Control).Tag as Calculator).getOutput();
                        clicks++;
                    }
                    else if (clicks == 1) {
                        if (panel.Tag is Calculator) {
                            (panel.Tag as Calculator).setParent(parent);
                        }
                        else if (panel.Tag is IfOperator) {
                            (panel.Tag as IfOperator).setParent(parent);
                        }
                        else if (panel.Tag is WarningSettings) {
                            (panel.Tag as WarningSettings).setParent(parent);
                        }
                        clicks = 0;
                        parentControl = null;
                        parent = null;
                    }
                }
                else if (sender is Panel && (sender as Panel).Name.Equals("OutputPanel")) {
                    if(clicks == 1) {
                        if (parent is DataTemplate) {
                            //TODO DataTemplate
                            (sender as Panel).Tag = (parent as DataTemplate).getId().ToString();
                        }
                        else {
                            (sender as Panel).Tag = parent;
                        }
                        clicks = 0;
                        parentControl = null;
                        parent = null;
                    }
                }
            }
             
        }

        public void connectTool_Click(object sender, EventArgs e)
        {
            connectToolSelected = true;
            clicks = 0;
        }

        public void setConnectTool(bool value)
        {
            connectToolSelected = value;
            clicks = 0;
        }
    }
}
