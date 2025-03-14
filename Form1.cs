using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;


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

            collections.LibraryAdded += (sender, message) => MessageBox.Show(message, "Событие", MessageBoxButtons.OK, MessageBoxIcon.Information);
            collections.LibraryRemoved += (sender, message) => MessageBox.Show(message, "Событие", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            collections.LibraryUpdated += (sender, message) => MessageBox.Show(message, "Событие", MessageBoxButtons.OK, MessageBoxIcon.Information);
            collections.CollectionCleared += (sender, message) => MessageBox.Show(message, "Событие", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            string phoneNumber = txtphonenumber.Text;
            string foundedYearText = txtFoundedYear.Text;
            bool hasDigitalLibrary = checkBox1.Checked; 

            try
            {
                if (collections.Count >= max_libraries) // Исправлено на >=
                {
                    throw new Exception("Превышено количество библиотек"); // Исправлено на Exception
                }

                int bookFund = int.Parse(bookFundText);
                int seats = int.Parse(seatsText);
                int foundedYear = int.Parse(foundedYearText);

                // Проверяем, какой метод создания объекта выбран
                if (standartConstruct.Checked) // Стандартный конструктор
                {
                  
                    ILibraryDetails libraryDetails = new LibraryDetails(name, bookFund, seats, foundedYear, phoneNumber, hasDigitalLibrary);
   
                    if (comboBox1.SelectedIndex == 0) 
                    {
                        currentLibrary = new SchoolLibrary(libraryDetails);
                    }
                    else // Университетская библиотека
                    {
                        currentLibrary = new UniversityLibrary(libraryDetails);
                    }

                    currentLibrary.Name = name;
                }
                else if (builder.Checked) // Строитель (Builder)
                {
                    // Определяем тип библиотеки
                    LibraryBuilder.LibraryType libraryType = comboBox1.SelectedIndex == 0
                        ? LibraryBuilder.LibraryType.School
                        : LibraryBuilder.LibraryType.University;

                    currentLibrary = new LibraryBuilder()
                        .SetName(name)
                        .SetBookFund(bookFund)
                        .SetReadingRoomSeats(seats)
                        .SetFoundedYear(foundedYear)
                        .SetPhoneNumber(phoneNumber)
                        .SetHasDigitalLibrary(hasDigitalLibrary)
                        .SetLibraryType(libraryType)
                        .Build();
                }
                else
                {
                    MessageBox.Show("Выберите метод создания библиотеки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Добавляем библиотеку в коллекцию
                collections.AddLibrary(currentLibrary);

                // Добавляем библиотеку в ListView
                ListViewItem item = new ListViewItem(name);
                item.SubItems.Add(comboBox1.SelectedItem.ToString()); // Тип библиотеки
                item.SubItems.Add(bookFund.ToString());
                item.SubItems.Add(seats.ToString());
                item.SubItems.Add(foundedYear.ToString());
                item.SubItems.Add(phoneNumber);
                item.SubItems.Add(hasDigitalLibrary?"Да":"Нет");
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
                comboBox1.Text = selectedItem.SubItems[1].Text;
                txtBookFund.Text = selectedItem.SubItems[2].Text;
                txtSeats.Text = selectedItem.SubItems[3].Text;
                txtFoundedYear.Text = selectedItem.SubItems[4].Text;
                txtphonenumber.Text = selectedItem.SubItems[5].Text;
                checkBox1.Checked = (selectedItem.SubItems[6].Text == "Да");
            }
        }
        private void ClearTextonTextBox()
        {
            txtName.Text = "";
            txtSeats.Text = "";
            txtBookFund.Text = "";
            txtFoundedYear.Text = "";
            textfromcont.Text = "";
            txtphonenumber.Text = " ";
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
            if (currentLibrary != null && collections.Count > 0 && ContainerLibraries.SelectedItems.Count > 0)
            {
                try
                {
                    ListViewItem selectedItem = ContainerLibraries.SelectedItems[0];
                    if (comboBox1.SelectedItem.ToString() != selectedItem.SubItems[1].Text)
                        throw new Exception("Нельзя менять тип библиотеки!");
                    // Получаем новые значения из текстовых полей
                    string name = txtName.Text.Trim();
                    int bookFund = int.Parse(txtBookFund.Text.Trim());
                    int seats = int.Parse(txtSeats.Text.Trim());
                    int foundedYear = int.Parse(txtFoundedYear.Text.Trim());
                    string phoneNumber = txtphonenumber.Text.Trim();
                    bool hasDigitalLibrary = checkBox1.Checked;

                    // Обновляем текущую библиотеку
                    ILibraryDetails updatedDetails = new LibraryDetails(name, bookFund, seats, foundedYear, phoneNumber, hasDigitalLibrary);

                    // Создаем новую абстракцию библиотеки на основе обновленных данных
                    Library updatedLibrary;
                    if (currentLibrary is SchoolLibrary)
                    {
                        updatedLibrary = new SchoolLibrary(updatedDetails);
                    }
                    else if (currentLibrary is UniversityLibrary)
                    {
                        updatedLibrary = new UniversityLibrary(updatedDetails);
                    }
                    else
                    {
                        throw new InvalidOperationException("Неизвестный тип библиотеки");
                    }

                    updatedLibrary.Name = name;

                    // Обновляем библиотеку в коллекции
                    collections.UpdateLibrary(name, updatedLibrary);

                    // Обновляем текущую библиотеку
                    currentLibrary = updatedLibrary;

                    // Обновляем ListView
                    selectedItem.SubItems[0].Text = name;
                    selectedItem.SubItems[1].Text = comboBox1.SelectedItem.ToString();
                    selectedItem.SubItems[2].Text = bookFund.ToString();
                    selectedItem.SubItems[3].Text = seats.ToString();
                    selectedItem.SubItems[4].Text = foundedYear.ToString();
                    selectedItem.SubItems[5].Text = phoneNumber;
                    selectedItem.SubItems[6].Text = hasDigitalLibrary ? "Да" : "Нет";

                    // Обновляем отображение 16-ричного формата фонда книг
                    sixteenx.Text = $"Фонд в 16-ричной СС: {bookFund:X}";
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ошибка ввода! Проверьте корректность нового значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Библиотека не выбрана или не создана!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void MeasurePerformance()
        {
            //int count = 10000000;
            //Dictionary<int, Library> libraryDict = new Dictionary<int, Library>();
            //Library[] libraryArray = new Library[count];
            //Random random = new Random();
            //Stopwatch stopwatch = new Stopwatch();
            //// Очистка ListView перед новым тестом
            //listViewforTests.Items.Clear();
            //stopwatch.Start();
            //for (int i = 0; i < count; i++)
            //{
            //    Library lib = new Library($"Библиотека {i}", random.Next(100, 10000));
            //    libraryDict[i] = lib;
            //    libraryArray[i] = lib;
            //}
            //stopwatch.Stop();
            //listViewforTests.Items.Add(new ListViewItem(new[] { "Заполнение", "Dictionary", stopwatch.ElapsedMilliseconds.ToString() }));
            //listViewforTests.Items.Add(new ListViewItem(new[] { "Заполнение", "Array", stopwatch.ElapsedMilliseconds.ToString() }));


            //stopwatch.Restart();
            //foreach (var item in libraryDict.Values) { var temp = item.Name; }
            //stopwatch.Stop();
            //listViewforTests.Items.Add(new ListViewItem(new[] { "Последовательный доступ", "Dictionary", stopwatch.ElapsedMilliseconds.ToString() }));

            //stopwatch.Restart();
            //foreach (var item in libraryArray) { var temp = item.Name; }
            //stopwatch.Stop();
            //listViewforTests.Items.Add(new ListViewItem(new[] { "Последовательный доступ", "Array", stopwatch.ElapsedMilliseconds.ToString() }));

            //// 3️. Случайный доступ к 100 000 элементам
            //stopwatch.Restart();
            //for (int i = 0; i < count; i++) { var temp = libraryDict[random.Next(count)].Name; }
            //stopwatch.Stop();
            //listViewforTests.Items.Add(new ListViewItem(new[] { "Случайный доступ", "Dictionary", stopwatch.ElapsedMilliseconds.ToString() }));

            //stopwatch.Restart();
            //for (int i = 0; i < count; i++) { var temp = libraryArray[random.Next(count)].Name; }
            //stopwatch.Stop();
            //listViewforTests.Items.Add(new ListViewItem(new[] { "Случайный доступ", "Array", stopwatch.ElapsedMilliseconds.ToString() }));
            //MessageBox.Show("Тестирование завершено!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
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