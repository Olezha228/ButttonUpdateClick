using ButtonUpdate.Model;
using ButtonUpdate.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;

namespace ButtonUpdate.ViewModels
{
    public class ViewModelBase
    {
        public CheckUpdatesCommand SimpleCommand { get; set; }

        public ViewModelBase()
        {
            SimpleCommand = new CheckUpdatesCommand(this);
        }

        public void CheckUpdatesAfterClick()
        {
            if (Updates.AreFound())
            {

            }
            else
            {
                Internet internet = new Internet();
                if (internet.IsConnected())
                    MessageBox.Show("Connected!");
                else
                    MessageBox.Show("Not Connected!");

            }
        }



    }
}
