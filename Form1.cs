using System;
using System.Linq;
using System.Windows.Forms;
using System.Net; 
//using System.Net.IPNetwork;
using LukeSkywalker.IPNetwork;
using System.Collections.Generic;

namespace IPcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string ipAddress = ipTextBox.Text;
                string subnetMask = maskComboBox.SelectedItem.ToString();

                IPAddress ip = IPAddress.Parse(ipAddress);
                IPAddress mask = IPAddress.Parse(subnetMask);

                // Получаем адрес сети и широковещательный адрес
                IPAddress networkAddress = GetNetworkAddress(ip, mask);
                IPAddress broadcastAddress = GetBroadcastAddress(ip, mask);

                // Определяем диапазон хостов для основной подсети
                List<IPAddress> hosts = GetHostRange(networkAddress, broadcastAddress);

                // Заполняем текстовые поля результатами для основной подсети
                networkAddressTextBox.Text = networkAddress.ToString();
                firstHostTextBox.Text = hosts[0].ToString(); // первый хост
                lastHostTextBox.Text = hosts[hosts.Count - 1].ToString(); // последний хост
                broadcastTextBox.Text = broadcastAddress.ToString();

                // Вычисляем количество хостов, исключая сетевой и широковещательный адрес
                int numberOfHosts = hosts.Count - 1; // правильно добавляем +1

                numberOfHostsTextBox.Text = numberOfHosts.ToString(); // количество хостов

                decimalValueTextBox.Text = networkAddress.ToString(); // здесь нужно определить, какое именно значение выводить
                binaryValueTextBox.Text = IPAddressToBinary(networkAddress); // аналогично

                // Устанавливаем длину префикса (CIDR)
                prefixLengthTextBox.Text = CountSetBits(mask.GetAddressBytes()).ToString();

                // Расчет и заполнение информации для подсетей (примерный код)
                var subnets = CalculateSubnets(networkAddress, mask, 2); // расчитать 2 подсети

                if (subnets != null && subnets.Count >= 2)
                {
                    // Подсчет и заполнение информации для первой подсети
                    subnet1NetworkTextBox.Text = subnets[0].ToString();
                    List<IPAddress> subnet1Hosts = GetHostRange(subnets[0], GetBroadcastAddress(subnets[0], mask));
                    subnet1MinHostTextBox.Text = subnet1Hosts[0].ToString(); // первый хост
                    subnet1MaxHostTextBox.Text = subnet1Hosts[subnet1Hosts.Count - 1].ToString(); // последний хост
                    subnet1BroadcastTextBox.Text = GetBroadcastAddress(subnets[0], mask).ToString();

                    // Вычисляем количество хостов для первой подсети
                    int subnet1NumberOfHosts = subnet1Hosts.Count - 1; // правильно добавляем +1
                    subnet1NumberOfHostsTextBox.Text = subnet1NumberOfHosts.ToString(); // количество хостов

                    // Подсчет и заполнение информации для второй подсети
                    subnet2NetworkTextBox.Text = subnets[1].ToString();
                    List<IPAddress> subnet2Hosts = GetHostRange(subnets[1], GetBroadcastAddress(subnets[1], mask));
                    subnet2MinHostTextBox.Text = subnet2Hosts[0].ToString(); // первый хост
                    subnet2MaxHostTextBox.Text = subnet2Hosts[subnet2Hosts.Count - 1].ToString(); // последний хост
                    subnet2BroadcastTextBox.Text = GetBroadcastAddress(subnets[1], mask).ToString();

                    // Вычисляем количество хостов для второй подсети
                    int subnet2NumberOfHosts = subnet2Hosts.Count - 1; // правильно добавляем +1
                    subnet2NumberOfHostsTextBox.Text = subnet2NumberOfHosts.ToString(); // количество хостов
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }





        private bool IsIpAddressInRange(IPAddress ipAddress, IPAddress networkAddress, IPAddress broadcastAddress)
        {
            byte[] ipBytes = ipAddress.GetAddressBytes();
            byte[] networkBytes = networkAddress.GetAddressBytes();
            byte[] broadcastBytes = broadcastAddress.GetAddressBytes();

            // Сравниваем IP-адрес с сетевым и широковещательным адресами
            for (int i = 0; i < ipBytes.Length; i++)
            {
                if (ipBytes[i] < networkBytes[i] || ipBytes[i] > broadcastBytes[i])
                {
                    return false;
                }
            }

            return true;
        }





        private IPAddress GetNetworkAddress(IPAddress ip, IPAddress mask)
        {
            byte[] ipBytes = ip.GetAddressBytes();
            byte[] maskBytes = mask.GetAddressBytes();
            byte[] resultBytes = new byte[ipBytes.Length];

            for (int i = 0; i < ipBytes.Length; i++)
            {
                resultBytes[i] = (byte)(ipBytes[i] & maskBytes[i]);
            }

            return new IPAddress(resultBytes);
        }

        private IPAddress GetBroadcastAddress(IPAddress ip, IPAddress mask)
        {
            byte[] ipBytes = ip.GetAddressBytes();
            byte[] maskBytes = mask.GetAddressBytes();
            byte[] invertedMaskBytes = maskBytes.Select(b => (byte)~b).ToArray();
            byte[] broadcastBytes = new byte[ipBytes.Length];

            for (int i = 0; i < ipBytes.Length; i++)
            {
                broadcastBytes[i] = (byte)(ipBytes[i] | invertedMaskBytes[i]);
            }

            return new IPAddress(broadcastBytes);
        }

        private List<IPAddress> GetHostRange(IPAddress networkAddress, IPAddress broadcastAddress)
        {
            List<IPAddress> hosts = new List<IPAddress>();

            byte[] startBytes = networkAddress.GetAddressBytes();
            byte[] endBytes = broadcastAddress.GetAddressBytes();

            // Определяем начальный адрес хоста (сетевой адрес + 1)
            byte[] currentBytes = { startBytes[0], startBytes[1], startBytes[2], (byte)(startBytes[3] + 1) };
            IPAddress currentHost = new IPAddress(currentBytes);

            // Определяем конечный адрес хоста (широковещательный адрес - 1)
            byte[] lastBytes = { endBytes[0], endBytes[1], endBytes[2], (byte)(endBytes[3] - 1) };
            IPAddress lastHost = new IPAddress(lastBytes);

            // Проверяем, что начальный адрес меньше или равен конечному, иначе список будет пустым
            if (IsIpAddressInRange(currentHost, networkAddress, broadcastAddress) &&
                IsIpAddressInRange(lastHost, networkAddress, broadcastAddress))
            {
                // Добавляем хосты в список
                hosts.Add(currentHost);

                // Добавляем все хосты между currentHost и lastHost включительно
                while (!currentHost.Equals(lastHost))
                {
                    byte[] nextBytes = { currentBytes[0], currentBytes[1], currentBytes[2], (byte)(currentBytes[3] + 1) };
                    currentHost = new IPAddress(nextBytes);
                    hosts.Add(currentHost);
                    currentBytes = nextBytes;
                }
            }

            return hosts;
        }






        private int CountSetBits(byte[] bytes)
        {
            int count = 0;
            foreach (byte b in bytes)
            {
                for (int i = 0; i < 8; i++)
                {
                    if ((b & (1 << i)) != 0)
                        count++;
                }
            }
            return count;
        }

        private List<IPAddress> CalculateSubnets(IPAddress networkAddress, IPAddress mask, int numberOfSubnets)
        {
            List<IPAddress> subnets = new List<IPAddress>();

            // Преобразуем маску в битовое представление
            byte[] maskBytes = mask.GetAddressBytes();
            uint maskValue = BitConverter.ToUInt32(maskBytes.Reverse().ToArray(), 0);

            // Получаем маску в виде целого числа
            int maskLength = CountSetBits(maskBytes);

            // Вычисляем количество битов, используемых для подсети
            int subnetBits = (int)Math.Ceiling(Math.Log(numberOfSubnets, 2));

            // Проверяем, достаточно ли битов в маске для разделения на указанное количество подсетей
            if (maskLength + subnetBits > 32)
            {
                throw new ArgumentException("Недостаточно бит в маске для разделения на указанное количество подсетей.");
            }

            // Переводим адрес сети в 32-битное число
            byte[] networkBytes = networkAddress.GetAddressBytes().Reverse().ToArray();
            uint networkValue = BitConverter.ToUInt32(networkBytes, 0);

            // Вычисляем размер одной подсети
            uint subnetSize = (uint)Math.Pow(2, 32 - (maskLength + subnetBits));

            // Вычисляем подсети
            for (int i = 0; i < numberOfSubnets; i++)
            {
                uint subnetStart = networkValue + (uint)(i * subnetSize);
                byte[] subnetStartBytes = BitConverter.GetBytes(subnetStart).Reverse().ToArray();
                subnets.Add(new IPAddress(subnetStartBytes));
            }

            return subnets;
        }


        private string IPAddressToBinary(IPAddress ipAddress)
        {
            byte[] bytes = ipAddress.GetAddressBytes();
            string binary = string.Join(".", bytes.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));
            return binary;
        }

    }
}
