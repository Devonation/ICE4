using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GenericDictionary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CustomDictionary<Device, string> deviceStatusDic = new();
        
        public MainWindow()
        {
            InitializeComponent();
            txbk_DeviceList.Text = deviceStatusDic.Display();
        }

        private void bt_DeviceAdd_Click(object sender, RoutedEventArgs e)
        {
            string name = txb_DeviceName.Text;
            if (int.TryParse(txb_DeviceRAM.Text, out int ram) && int.TryParse(txb_DeviceStorage.Text, out int storage))
            {
                deviceStatusDic.Add(new Device(name, ram, storage), "good");
                txbk_DeviceList.Text = deviceStatusDic.Display();

                txb_DeviceName.Clear();
                txb_DeviceRAM.Clear();
                txb_DeviceStorage.Clear();
            }
        }

        private void bt_DeviceRemove_Click(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(txb_DeviceIndex.Text, out int index))
            {
                deviceStatusDic.RemoveAtIndex(index - 1);
                txbk_DeviceList.Text = deviceStatusDic.Display();
                txb_DeviceIndex.Clear();
            }
        }

        private void bt_DeviceUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txb_DeviceIndex.Text, out int index))
            {
                if (deviceStatusDic.FindKey(index - 1) != default)
                {
                    deviceStatusDic.UpdateValueAtKey(deviceStatusDic.FindKey(index - 1), txb_DeviceUpdate.Text);
                }
            }
            txbk_DeviceList.Text = deviceStatusDic.Display();
            txb_DeviceUpdate.Clear();
            txb_DeviceIndex.Clear();
        }
    }
}