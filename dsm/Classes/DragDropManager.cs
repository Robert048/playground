﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dsm
{
    /// <summary>
    /// Takes care of dragging of controls and adding all the correct events
    /// </summary>
    class DragDropManager
    {
        Control activeControl;
        Point previousLocation;
        ConnectManager connectManager;

        public DragDropManager() { }
        //test
        public DragDropManager(ConnectManager connectManager)
        {
            this.connectManager = connectManager;
        }

        #region Drag Controls
        /// <summary>
        /// Called for making a panel suitable for drag events
        /// </summary>
        /// <param name="panel"></param>
        public void makePanelDraggable(Panel panel)
        {
            panel.DragDrop += playGround_DragDrop;
            panel.DragEnter += playGround_DragEnter;
            panel.DragOver += playGround_DragOver;
        }

        private void playGround_DragDrop(object sender, DragEventArgs e)
        {
            activeControl.Location = (sender as Panel).PointToClient(Cursor.Position);
            (sender as Panel).Controls.Add(activeControl);
            activeControl.BringToFront();
            Console.WriteLine(activeControl.Text);
            activeControl = null;
        }

        private void playGround_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void playGround_DragOver(object sender, DragEventArgs e)
        {
            //Creates a preview of what your actually dragging
            //panel.Location = mainPanel.PointToClient(new Point(e.X, e.Y));
            activeControl.BringToFront();
        }
        #endregion Drag Controls

        #region Move Controls
        /// <summary>
        /// Adds all events that makes the control draggable after creation
        /// </summary>
        /// <param name="control"></param>
        public void makeControlMove(Control control)
        {
            control.MouseDown += new MouseEventHandler(control_MouseDown);
            control.MouseUp += new MouseEventHandler(control_MouseUp);
            control.MouseMove += new MouseEventHandler(control_MouseMove);
        }

        private void control_MouseDown(object sender, MouseEventArgs e)
        {
            activeControl = sender as Control;
            activeControl.BringToFront();
            previousLocation = e.Location;
            Cursor.Current = Cursors.SizeAll;
        }

        private void control_MouseMove(object sender, MouseEventArgs e)
        {
            if (activeControl == null || activeControl != sender) {
                return;
            }
            var location = activeControl.Location;

            activeControl.BringToFront();
            location.Offset(e.Location.X - previousLocation.X, e.Location.Y - previousLocation.Y);
            activeControl.Location = location;
        }

        private void control_MouseUp(object sender, MouseEventArgs e)
        {
            activeControl.BringToFront();
            activeControl = null;
            Cursor.Current = Cursors.Default;
        }
        #endregion Move Controls

        
        #region Start Drag Events

        // Selecteert Drag Item om te slepen op het playground
        public void comboBox_MouseDown_label(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && (sender as ComboBox).DroppedDown == false) {
                Label label = new Label();
                if ((sender as ComboBox).SelectedItem != null) {
                    string value = (sender as ComboBox).SelectedItem.ToString();
                    int split = value.IndexOf(':') + 1;
                    label.Text = value.Substring(split, value.Length - split);
                }
                else {
                    string value = (sender as ComboBox).Text;
                    int split = value.IndexOf(':') + 1;
                    label.Text = value.Substring(split, value.Length - split);
                }

                label.AutoSize = true;
                makeControlMove(label);
                setActiveControl(label);
                (sender as ComboBox).DoDragDrop(label, DragDropEffects.All);
            }
        }

        public void comboBox_MouseDown_panel(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && (sender as ComboBox).DroppedDown == false) {
                Label label = new Label();
                Panel panel = new Panel();
                
                panel.Controls.Add(label);
                panel.Size = new Size(100, 100);
                panel.Tag = (sender as ComboBox).Tag;
                panel.BackColor = Color.Aquamarine;
                panel.Click += connectManager.panel_Click;

                label.Text = (sender as ComboBox).Text;
                label.AutoSize = true;
                label.Tag = (sender as ComboBox).Tag;
                label.Location = new Point((panel.Width / 2) - (label.Width / 2), 10);
                label.Click += connectManager.panel_Click;

                makeControlMove(panel);
                setActiveControl(panel);
                (sender as ComboBox).DoDragDrop(panel, DragDropEffects.All);
            }
        }
        #endregion Start Drag Events

        public void setActiveControl(Control control)
        {
            activeControl = control;
        }
    }
}