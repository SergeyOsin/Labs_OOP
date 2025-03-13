using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;
using static Library;

namespace _1_Lab_Library
{
    public partial class Form1 : Form
    {
        private int max_libraries;
        private Collections collections;
        private Library currentLibrary; // Храним созданную библиотеку
        public Form1(int _max_libraries)
        {
            this.max_libraries = _max_libraries;
            InitializeComponent();
            SubscribeToEvents();
            collections = new Collections();


            // Подписываемся на события с использованием лямбда-выражений
            // Теперь LibraryAdded указывает на этот метод и будет вызывать его при срабатывании.
            collections.LibraryAdded += (sender, message) => MessageBox.Show(message, "Событие", MessageBoxButtons.OK, MessageBoxIcon.Information);
            collections.LibraryRemoved += (sender, message) => MessageBox.Show(message, "Событие", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            collections.LibraryUpdated += (sender, message) => MessageBox.Show(message, "Событие", MessageBoxButtons.OK, MessageBoxIcon.Information);
            collections.CollectionCleared += (sender, message) => MessageBox.Show(message, "Событие", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ContainerLibraries.SelectedIndexChanged += ContainerLibraries_SelectedIndexChanged;
        }

        private void SubscribeToEvents()
        {
            btnCreateLibrary.Click += btnCreateLibrary_Click;
            btnShowHex.Click += btnShowHex_Click;
            btnClose_Click.Click += btnClose_Click_Click;
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            btnUpdateFields.Click += btnUpdateFields_Click;
            ContainerLibraries.SelectedIndexChanged += ContainerLibraries_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
        private void btnCreateLibrary_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string bookFundText = txtBookFund.Text;
            string seatsText = txtSeats.Text;
            string feeText = txtFee.Text;
            string foundedYearText = txtFoundedYear.Text;

            try
            {
                if (collections.Count > max_libraries)
                {
                    throw new StackOverflowException("Превышено количество библиотек");
                }

                int bookFund = int.Parse(bookFundText);
                int seats = int.Parse(seatsText);
                double fee = double.Parse(feeText);
                int foundedYear = int.Parse(foundedYearText);

                // Проверяем, какой метод создания объекта выбран
                if (standartConstruct.Checked) // Стандартный конструктор
                {
                    currentLibrary = new Library(name, bookFund, seats, fee, foundedYear);
                }
                else if (builder.Checked) // Строитель (Builder)
                {
                    currentLibrary = new LibraryBuilder()
                        .SetName(name)
                        .SetBookFund(bookFund)
                        .SetReadingRoomSeats(seats)
                        .SetSubscriptionFee(fee)
                        .SetFoundedYear(foundedYear)
                        .Build();
                }
                else
                {
                    MessageBox.Show("Выберите метод создания библиотеки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                collections.AddLibrary(currentLibrary);

                ListViewItem item = new ListViewItem(name);
                item.SubItems.Add(bookFund.ToString());
                item.SubItems.Add(fee.ToString());
                item.SubItems.Add(seats.ToString());
                item.SubItems.Add(foundedYear.ToString());

                ContainerLibraries.Items.Add(item);
                lblObjectCount.Text = $"Количество библиотек: {collections.Count}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода! Проверьте корректность данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblObjectCount.Text = $"Количество библиотек: {collections.Count}";
            }
        }

        private void btnShowHex_Click(object sender, EventArgs e)
        {
            if (currentLibrary != null)
            {
                int number = int.Parse(txtBookFund.Text);
                sixteenx.Text = $"Фонд в 16-ричной СС: {Convert.ToString(number, 16)}";
            }
            else
            {
                MessageBox.Show("Библиотека не создана!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnClose_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (collections.Count == 0)
                throw new Exception("Создайте библиотеку!");

            if (ContainerLibraries.SelectedItems.Count > 0)
            {
                string selectedLibraryName = ContainerLibraries.SelectedItems[0].SubItems[0].Text;
                collections.RemoveLibrary(selectedLibraryName);
                ContainerLibraries.Items.Remove(ContainerLibraries.SelectedItems[0]);
                lblObjectCount.Text = $"Количество библиотек: {collections.Count}";
                ClearTextonTextBox();
            }
            else
            {
                throw new Exception("Выберите библиотеку");
            }
        }

        private void ContainerLibraries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContainerLibraries.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = ContainerLibraries.SelectedItems[0];
                txtName.Text = selectedItem.SubItems[0].Text;
                txtBookFund.Text = selectedItem.SubItems[1].Text;
                txtSeats.Text = selectedItem.SubItems[3].Text;
                txtFee.Text = selectedItem.SubItems[2].Text;
                txtFoundedYear.Text = selectedItem.SubItems[4].Text;
            }
        }
        private void ClearTextonTextBox()
        {
            txtName.Text = "";
            txtSeats.Text = "";
            txtBookFund.Text = "";
            txtFoundedYear.Text = "";
            txtFee.Text = "";
            textfromcont.Text = "";
            sixteenx.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (ContainerLibraries.Items.Count == 0)
                throw new Exception("Контейнер пуст");

            ContainerLibraries.Items.Clear();
            collections.Clear(); // Очистка коллекции
            lblObjectCount.Text = $"Количество библиотек: {collections.Count}";
            textfromcont.Text = "";
            ClearTextonTextBox();
        }

        private void btnUpdateFields_Click(object sender, EventArgs e)
        {
            if (currentLibrary != null && collections.Count > 0)
            {
                try
                {
                    string name = txtName.Text.Trim();
                    int bookFund = int.Parse(txtBookFund.Text.Trim());
                    int seats = int.Parse(txtSeats.Text.Trim());
                    int fee = int.Parse(txtFee.Text.Trim());
                    int foundedYear = int.Parse(txtFoundedYear.Text.Trim());
                    sixteenx.Text = $"Фонд в 16-ричной СС: {Convert.ToString(bookFund, 16)}";
                    // Обновление текущей библиотеки
                    currentLibrary = new Library(name, bookFund, seats, fee, foundedYear);
                    // Обновление библиотеки в коллекции
                    collections.UpdateLibrary(name, currentLibrary);
                    // Обновление ListView
                    if (ContainerLibraries.SelectedItems.Count > 0)
                    {
                        ListViewItem selectedItem = ContainerLibraries.SelectedItems[0];
                        selectedItem.SubItems[0].Text = name;
                        selectedItem.SubItems[1].Text = bookFund.ToString();
                        selectedItem.SubItems[2].Text = fee.ToString("");
                        selectedItem.SubItems[3].Text = seats.ToString();
                        selectedItem.SubItems[4].Text = foundedYear.ToString();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ошибка ввода! Проверьте корректность нового значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Библиотека не создана!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void MeasurePerformance()
        {
            int count = 10000000;
            Dictionary<int, Library> libraryDict = new Dictionary<int, Library>();
            Library[] libraryArray = new Library[count];
            Random random = new Random();
            Stopwatch stopwatch = new Stopwatch();
            // Очистка ListView перед новым тестом
            listViewforTests.Items.Clear();
            stopwatch.Start();
            for (int i = 0; i < count; i++)
            {
                Library lib = new Library($"Библиотека {i}", random.Next(100, 10000));
                libraryDict[i] = lib;
                libraryArray[i] = lib;
            }
            stopwatch.Stop();
            listViewforTests.Items.Add(new ListViewItem(new[] { "Заполнение", "Dictionary", stopwatch.ElapsedMilliseconds.ToString() }));
            listViewforTests.Items.Add(new ListViewItem(new[] { "Заполнение", "Array", stopwatch.ElapsedMilliseconds.ToString() }));


            stopwatch.Restart();
            foreach (var item in libraryDict.Values) { var temp = item.Name; }
            stopwatch.Stop();
            listViewforTests.Items.Add(new ListViewItem(new[] { "Последовательный доступ", "Dictionary", stopwatch.ElapsedMilliseconds.ToString() }));

            stopwatch.Restart();
            foreach (var item in libraryArray) { var temp = item.Name; }
            stopwatch.Stop();
            listViewforTests.Items.Add(new ListViewItem(new[] { "Последовательный доступ", "Array", stopwatch.ElapsedMilliseconds.ToString() }));

            // 3️. Случайный доступ к 100 000 элементам
            stopwatch.Restart();
            for (int i = 0; i < count; i++) { var temp = libraryDict[random.Next(count)].Name; }
            stopwatch.Stop();
            listViewforTests.Items.Add(new ListViewItem(new[] { "Случайный доступ", "Dictionary", stopwatch.ElapsedMilliseconds.ToString() }));

            stopwatch.Restart();
            for (int i = 0; i < count; i++) { var temp = libraryArray[random.Next(count)].Name; }
            stopwatch.Stop();
            listViewforTests.Items.Add(new ListViewItem(new[] { "Случайный доступ", "Array", stopwatch.ElapsedMilliseconds.ToString() }));
            MessageBox.Show("Тестирование завершено!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRunTest_Click(object sender, EventArgs e)
        {
            MeasurePerformance();
        }

        private void builder_CheckedChanged(object sender, EventArgs e)
        {
            if (builder.Checked)
            {
                standartConstruct.Checked = false;
            }
        }

        private void standartConstruct_CheckedChanged(object sender, EventArgs e)
        {
            if (standartConstruct.Checked)
            {
                builder.Checked = false;
            }
        }
    }
}