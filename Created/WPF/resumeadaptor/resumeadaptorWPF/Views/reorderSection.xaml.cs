using resumeadaptorWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace resumeadaptorWPF.Views
{
    /// <summary>
    /// Logique d'interaction pour reorderSection.xaml
    /// </summary>
    public partial class reorderSection : Window
    {
        public section selectedsection;
        public reorderSection(section sectionvar)
        {
            InitializeComponent();
            selectedsection = sectionvar;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //next solution create copy remave insert at
            //replacing the cv does note work
            //removeat insert did not work
            App.myCv.Sections.RemoveAt(selectedsection.Id);
            string v_dbg = wayCombo.SelectedItem.ToString();
            if (v_dbg.Contains("Up") )
            {
                selectedsection.Id = selectedsection.Id-1;
                App.myCv.Sections.Insert(selectedsection.Id , selectedsection);
                //int i = 0;
                cv cvcopie = new cv();
                int length = App.myCv.Sections.Count();
                for (int i = 0; i < length; i++)
                {
                    section itemcopie = new section();
                    itemcopie.Id = i;
                    itemcopie.Order = App.myCv.Sections[i].Order;
                    itemcopie.SubSections = App.myCv.Sections[i].SubSections;
                    itemcopie.Text = App.myCv.Sections[i].Text;
                    App.myCv.Sections.RemoveAt(i);
                    App.myCv.Sections.Insert(i, itemcopie);
                }
                    /*item.Id = i;
                    section itemcopie = new section();
                    itemcopie.Id = item.Id;
                    itemcopie.Order = item.Order;
                    itemcopie.SubSections = item.SubSections;
                    itemcopie.Text = item.Text;
                    
                    cvcopie.Sections.Add(itemcopie);*/
                    //sol 1 //App.myCv.Sections.RemoveAt(i);
                    // //App.myCv.Sections.Insert(itemcopie.Id, itemcopie);
                    
                
                //App.myCv = cvcopie;
            }
            else
            {

                selectedsection.Id = selectedsection.Id + 1;
                App.myCv.Sections.Insert(selectedsection.Id , selectedsection);
                int i = 0;
                foreach (section item in App.myCv.Sections)
                {
                    item.Id = i;
                    i = i + 1;
                }
            }
            
            Close();
        }
    }
}
