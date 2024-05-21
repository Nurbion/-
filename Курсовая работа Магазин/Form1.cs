// Добавить исключение ошибок ввода пользователем везде где нету проверок
//Туду лист
/* 1)вывод меню для работы со списком√
 * 2)добавление товара в начало списка√
 * 3)добавление товара в конец списка√
 * 4)добавление нового товара,производителю;(проверить)
 * 5)добавление товара перед указанного товара√
 * 6)добавление товара после указанного товара√
 * 7)удаление (покупка) выбранного товара. готово(Уточнить у преподователя)
 * 8)вывод всех товаров на экран√
 * 9)при покупке каждого товара вводится уникальный номер, и программа уменьшает значение количества товара на единицу или выдает сообщение о том, что требуемого товара в магазине нет; Уточнить у преподователя
 * 10)по запросу выдаются сведения о наличии товаров в магазине√
 * 11)поиск товаров по названию√
 * 12)поиск товаров по производителю√
 * 13)сохранение данных списка товаров в текстовый файл√
 * 14)извлечение данных из текстового файла и помещение новых товаров в список√
 * 15)Программа должна обеспечивать диалог с помощью меню и  контроль ошибок при вводе. Доделать 
 * проверка ошибок список готовности:
 * 1) проверка на одинаковые айди сделать√
 * 2)Проверка на закрытие и спросить у пользователя сохранил ли он файл√
 * 3)Проверить чтобы пользователь не забывал вводить данные в текстбоксы√
 * 4)найти поставить огранич√
 * 5)удалить добавить пометку об отсутвии товара√
 * 
 * Немного сделать красивее интерфейс
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_работа_Магазин
{

    public partial class Form1 : Form
    {
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Category { get; set; }
            public int Year { get; set; }
            public string Maker { get; set; }
            public int Quantity { get; set; }
        }

        public class Node
        {
            public Product Data { get; set; }
            public Node Next { get; set; }
            public Node Prev { get; set; }

            public Node(Product data)
            {
                Data = data;
                Next = null;
                Prev = null;
            }
        }

        public class DoublyLinkedList
        {
            private Node head;
            private Node tail;
            public Node Head => head;

            public void Clear()
            {
                head = null;
                tail = null;
            }

            public DoublyLinkedList()
            {
                head = null;
                tail = null;
            }

            public void AddToFront(Product data)
            {
                Node newNode = new Node(data);
                if (head == null)
                {
                    head = tail = newNode;
                }
                else
                {
                    newNode.Next = head;
                    head.Prev = newNode;
                    head = newNode;
                }
            }

            public void AddToEnd(Product data)
            {
                Node newNode = new Node(data);
                if (tail == null)
                {
                    head = tail = newNode;
                }
                else
                {
                    newNode.Prev = tail;
                    tail.Next = newNode;
                    tail = newNode;
                }
            }

            public void AddSortedByMaker(Product data)
            {
                Node newNode = new Node(data);
                if (head == null)
                {
                    head = tail = newNode;
                }
                else
                {
                    Node current = head;
                    while (current != null && string.Compare(current.Data.Maker, data.Maker, StringComparison.OrdinalIgnoreCase) <= 0)
                    {
                        if (current.Data.Maker.Equals(data.Maker, StringComparison.OrdinalIgnoreCase) && current.Data.Id == data.Id)
                        {
                            current.Data.Quantity += data.Quantity;
                            return;
                        }
                        current = current.Next;
                    }

                    if (current == head)
                    {
                        AddToFront(data);
                    }
                    else if (current == null)
                    {
                        AddToEnd(data);
                    }
                    else
                    {
                        newNode.Prev = current.Prev;
                        newNode.Next = current;
                        current.Prev.Next = newNode;
                        current.Prev = newNode;
                    }
                }
            }

            public bool ContainsId(int id)
            {
                var current = head;
                while (current != null)
                {
                    if (current.Data.Id == id)
                    {
                        return true;
                    }
                    current = current.Next;
                }
                return false;
            }

            public void AddBefore(int existingCode, Product newProduct)
            {
                var current = head;
                while (current != null)
                {
                    if (current.Data.Id == existingCode)
                    {
                        var newNode = new Node(newProduct);
                        newNode.Next = current;
                        newNode.Prev = current.Prev;

                        if (current.Prev != null)
                        {
                            current.Prev.Next = newNode;
                        }
                        else
                        {
                            head = newNode;
                        }

                        current.Prev = newNode;
                        return;
                    }
                    current = current.Next;
                }
                throw new Exception("Товар с указанным кодом не найден.");
            }

            public void AddAfter(int existingCode, Product newProduct)
            {
                var current = head;
                while (current != null)
                {
                    if (current.Data.Id == existingCode)
                    {
                        var newNode = new Node(newProduct);
                        newNode.Next = current.Next;
                        newNode.Prev = current;

                        if (current.Next != null)
                        {
                            current.Next.Prev = newNode;
                        }
                        current.Next = newNode;

                        // Если добавили в конец списка, обновляем tail
                        if (current == tail)
                        {
                            tail = newNode;
                        }
                        return;
                    }
                    current = current.Next;
                }
                throw new Exception("Товар с указанным кодом не найден.");
            }

            public void Remove(int code, int quantity)
            {
                var current = head;
                while (current != null)
                {
                    if (current.Data.Id == code)
                    {
                        if (current.Data.Quantity > quantity)
                        {
                            current.Data.Quantity -= quantity;
                        }
                        else
                        {
                            if (current == head)
                            {
                                head = head.Next;
                                if (head != null)
                                {
                                    head.Prev = null;
                                }
                            }
                            else if (current == tail)
                            {
                                tail = tail.Prev;
                                if (tail != null)
                                {
                                    tail.Next = null;
                                }
                            }
                            else
                            {
                                current.Prev.Next = current.Next;
                                current.Next.Prev = current.Prev;
                            }
                        }
                        return;
                    }
                    current = current.Next;
                }
                MessageBox.Show("Товар с таким кодом не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            public void LoadFromFile(string filePath)
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Файл не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 6)
                        {
                            Product product = new Product
                            {
                                Id = int.Parse(parts[0]),
                                Name = parts[1],
                                Category = parts[2],
                                Year = int.Parse(parts[3]),
                                Maker = parts[4],
                                Quantity = int.Parse(parts[5])
                            };
                            AddToEnd(product);
                        }
                    }
                }
            }

            public void SaveToFile(string filePath)
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    Node current = head;
                    while (current != null)
                    {
                        Product product = current.Data;
                        writer.WriteLine($"{product.Id},{product.Name},{product.Category},{product.Year},{product.Maker},{product.Quantity}");
                        current = current.Next;
                    }
                }
            }

            public List<Product> SearchByName(string name)
            {
                List<Product> result = new List<Product>();
                Node current = head;
                while (current != null)
                {
                    if (current.Data.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        result.Add(current.Data);
                    }
                    current = current.Next;
                }
                return result;
            }

            public List<Product> SearchByMaker(string maker)
            {
                List<Product> result = new List<Product>();
                Node current = head;
                while (current != null)
                {
                    if (current.Data.Maker.IndexOf(maker, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        result.Add(current.Data);
                    }
                    current = current.Next;
                }
                return result;
            }

            public List<Product> GetAvailableProducts()
            {
                List<Product> result = new List<Product>();
                Node current = head;
                while (current != null)
                {
                    if (current.Data.Quantity > 0)
                    {
                        result.Add(current.Data);
                    }
                    current = current.Next;
                }
                return result;
            }
            //Сюда
        }




    /// <summary>
    /// ///////////////////////////////////////////////////////////////////////////////////////
    /// </summary>




        public Form1()
        {
            InitializeComponent();
        }

        private DoublyLinkedList products = new DoublyLinkedList();
        private bool isDataChanged = false;
        private string currentFilePath;

        private void RefreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            var current = products.Head;
            while (current != null)
            {
                dataGridView1.Rows.Add(current.Data.Id, current.Data.Name, current.Data.Category, current.Data.Year, current.Data.Maker, current.Data.Quantity);
                current = current.Next;
            }
        }

        private void ClearTextBoxes()
        {
            textBoxId.Clear();
            textBoxName.Clear();
            textBoxCategory.Clear();
            textBoxMaker.Clear();
            textBoxYear.Clear();
            textBoxQuantity.Clear();
        }

        private Product GetProductFromInputWithValidation()
        {
            if (!int.TryParse(textBoxId.Text, out int Id))
            {
                MessageBox.Show("Неверный код товара.");
                return null;
            }

            if (products.ContainsId(Id))
            {
                MessageBox.Show("Товар с таким кодом уже существует.");
                return null;
            }

            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Название товара не должно быть пустым.");
                return null;
            }

            if (string.IsNullOrEmpty(textBoxCategory.Text))
            {
                MessageBox.Show("Категория товара не должна быть пустой.");
                return null;
            }

            if (string.IsNullOrEmpty(textBoxMaker.Text))
            {
                MessageBox.Show("Производитель товара не должен быть пустым.");
                return null;
            }

            if (!int.TryParse(textBoxYear.Text, out int year))
            {
                MessageBox.Show("Неверный год производства.");
                return null;
            }

            if (!int.TryParse(textBoxQuantity.Text, out int quantity))
            {
                MessageBox.Show("Неверное количество экземпляров.");
                return null;
            }



            var newProduct = new Product
            {
                Id = Id,
                Name = textBoxName.Text,
                Category = textBoxCategory.Text,
                Year = year,
                Maker = textBoxMaker.Text,
                Quantity = quantity
            };

            ClearTextBoxes();

            return newProduct;
        }   

        private void AddProductToFront() //поменять местами если что с ендом
        {
            var product = GetProductFromInputWithValidation();
            if (product != null)
            {
                products.AddToEnd(product);
                isDataChanged = true;
                RefreshDataGridView();
            }
        }

        private void AddProductToEnd()
        {
            var product = GetProductFromInputWithValidation();
            if (product != null)
            {
                products.AddToFront(product);
                isDataChanged = true;
                RefreshDataGridView();
            }
        }

        private void AddProductSortedByMaker()
        {
            var product = GetProductFromInputWithValidation();
            if (product != null)
            {
                products.AddSortedByMaker(product);
                isDataChanged = true;
                RefreshDataGridView();
            }
        }

        private void AddProductBefore()
        {
            using (Form inputForm = new Form())
            {
                inputForm.Text = "Добавить товар перед существующим";
                inputForm.StartPosition = FormStartPosition.CenterParent;

                Label labelExistingId = new Label() { Left = 20, Top = 20, Text = "Введите ID существующего товара:" };
                TextBox textBoxExistingId = new TextBox() { Left = 20, Top = 50, Width = 200 };
                Button confirmationButton = new Button() { Text = "ОК", Left = 20, Width = 100, Top = 80 };
                confirmationButton.DialogResult = DialogResult.OK;

                inputForm.Controls.Add(labelExistingId);
                inputForm.Controls.Add(textBoxExistingId);
                inputForm.Controls.Add(confirmationButton);
                inputForm.AcceptButton = confirmationButton;

                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    if (int.TryParse(textBoxExistingId.Text, out int existingId))
                    {
                        var product = GetProductFromInputWithValidation();
                        if (product != null)
                        {
                            try
                            {
                                products.AddBefore(existingId, product);
                                isDataChanged = true;
                                RefreshDataGridView();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите корректный ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AddProductAfter()
        {
            using (Form inputForm = new Form())
            {
                inputForm.Text = "Добавить товар после существующего";
                inputForm.StartPosition = FormStartPosition.CenterParent;

                Label labelExistingId = new Label() { Left = 20, Top = 20, Text = "Введите ID существующего товара:" };
                TextBox textBoxExistingId = new TextBox() { Left = 20, Top = 50, Width = 200 };
                Button confirmationButton = new Button() { Text = "ОК", Left = 20, Width = 100, Top = 80 };
                confirmationButton.DialogResult = DialogResult.OK;

                inputForm.Controls.Add(labelExistingId);
                inputForm.Controls.Add(textBoxExistingId);
                inputForm.Controls.Add(confirmationButton);
                inputForm.AcceptButton = confirmationButton;

                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    if (int.TryParse(textBoxExistingId.Text, out int existingId))
                    {
                        var product = GetProductFromInputWithValidation();
                        if (product != null)
                        {
                            try
                            {
                                products.AddAfter(existingId, product);
                                isDataChanged = true;
                                RefreshDataGridView();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите корректный ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void RemoveProductByCode(int code, int quantity)
        {
            products.Remove(code, quantity);
            isDataChanged = true;
            RefreshDataGridView();
        }

        private void PromptForProductCodeAndRemove()
        {
            using (Form inputForm = new Form())
            {
                inputForm.Text = "Удаление товара";
                inputForm.StartPosition = FormStartPosition.CenterParent;

                Label labelCode = new Label() { Left = 20, Top = 20, Text = "Введите код товара для удаления:" };
                TextBox textBoxCode = new TextBox() { Left = 20, Top = 50, Width = 200 };
                Label labelQuantity = new Label() { Left = 20, Top = 80, Text = "Введите количество для удаления:" };
                TextBox textBoxQuantity = new TextBox() { Left = 20, Top = 110, Width = 200 };
                Button confirmationButton = new Button() { Text = "Удалить", Left = 20, Width = 100, Top = 140 };
                confirmationButton.DialogResult = DialogResult.OK;

                inputForm.Controls.Add(labelCode);
                inputForm.Controls.Add(textBoxCode);
                inputForm.Controls.Add(labelQuantity);
                inputForm.Controls.Add(textBoxQuantity);
                inputForm.Controls.Add(confirmationButton);
                inputForm.AcceptButton = confirmationButton;

                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    if (int.TryParse(textBoxCode.Text, out int code) && int.TryParse(textBoxQuantity.Text, out int quantity))
                    {
                        RemoveProductByCode(code, quantity);
                    }
                    else
                    {
                        MessageBox.Show("Введите корректные данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CreateNewFile(string filePath)
        {
            currentFilePath = filePath;
            products.Clear();
            File.WriteAllText(currentFilePath, string.Empty); // Создаем или очищаем файл
            RefreshDataGridView();
            MessageBox.Show("Новый файл создан и открыт для работы.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void LoadDataFromFile(string filePath)
        {
            currentFilePath = filePath;
            products.LoadFromFile(filePath);
            RefreshDataGridView();
        }

        private void DisplaySearchResults(List<Product> results, string title)
        {
            if (results == null || results.Count == 0)
            {
                MessageBox.Show("Ничего не найдено.", "Результаты поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Form searchResultsForm = new Form();
            searchResultsForm.Text = title;
            searchResultsForm.StartPosition = FormStartPosition.CenterScreen;


            DataGridView dataGridView = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            dataGridView.Columns.Add("Id товара", "Id");
            dataGridView.Columns.Add("Наименование товара", "Name");
            dataGridView.Columns.Add("Категория", "Category");
            dataGridView.Columns.Add("Год производства", "Year");
            dataGridView.Columns.Add("Производитель", "Maker");
            dataGridView.Columns.Add("Количество", "Quantity");

            foreach (var product in results)
            {
                dataGridView.Rows.Add(product.Id, product.Name, product.Category, product.Year, product.Maker, product.Quantity);
            }

            searchResultsForm.Controls.Add(dataGridView);
            searchResultsForm.Size = new Size(800, 600);
            searchResultsForm.Show();
        }

        private void DisplayAvailableProducts()
        {
            List<Product> availableProducts = products.GetAvailableProducts();
            DisplaySearchResults(availableProducts, "Товары в наличии");

        }

        private void SearchProductsByName()
        {
            string name = textBoxSearchName.Text; // TextBox для ввода названия для поиска
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введите название для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<Product> result = products.SearchByName(name);
            DisplaySearchResults(result, $"Результаты поиска по названию '{name}'");
        }

        private void SearchProductsByMaker()
        {
            string maker = textBoxSearchMaker.Text; // TextBox для ввода производителя для поиска
            if (string.IsNullOrEmpty(maker))
            {
                MessageBox.Show("Введите название для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<Product> result = products.SearchByMaker(maker);
            DisplaySearchResults(result, $"Результаты поиска по производителю '{maker}'");
        }

        private void SaveDataToFile()
        {
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                products.SaveToFile(currentFilePath);
                MessageBox.Show("Данные сохранены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Файл не выбран. Сначала создайте или загрузите файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void добавитьТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void добавитьВКонецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductToEnd();
        }

        private void добавитьВКонецToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddProductToFront();
        }

        private void добавлениеТовараПередУказанногоТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductBefore();
        }

        private void добавитьТоварПоПроизводителюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductSortedByMaker();
        }

        private void добавитьТоварПередДругимТоваромToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductAfter();
        }

        private void удалитьТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
             PromptForProductCodeAndRemove();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadDataFromFile(openFileDialog.FileName);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDataToFile();
        }

        private void поискПоНазваниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchProductsByName();
            textBoxSearchName.Clear();
        }

        private void поискПоПроизводителюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchProductsByMaker();
            textBoxSearchMaker.Clear();
        }

        private void отобразитьТоварывналичииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayAvailableProducts();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    CreateNewFile(saveFileDialog.FileName);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isDataChanged)
            {
                var result = MessageBox.Show("У вас есть несохранённые изменения. Вы уверены, что хотите выйти без сохранения?",
                                             "Предупреждение",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Отмена закрытия формы
                }
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string helpText = @"
Приложение представляет собой таблицу,отображающая количество товаров в магазине, их производителя и год производства.
            Текущая версия: v0.7
            Функции приложения:
            1.Добавляет товар в таблицу.
            1.1.В начало таблицы
            1.2.В конец таблицы
            1.3.По производителю
            1.4.Перед указанным товаром
            1.5.После указанного товара
            2.Удаляет товар из таблицы по ID.
            3.Поиск по производителю и названию.
            4.Отображает товары в наличии
            5.Все данные хранятся в файле.
            6.Файл можно создать,открыть,сохранить.
---------------------------------------------------------------------
            Функции на доработке:
            1.Все данные вводятся в отдельном окне.
            2.Улучшение интерфейса.
            3.Добавление возможности указывания точек магазина.
            4.Поиск по ID.
            5.Мультиудаление товаров.
            6.Функция печати.
            7.Формирование отчета.
    ";

            MessageBox.Show(helpText, "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void авторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string author = @"
Создатели приложения:
Маресев Андрей Юрьевич(Студент 
НГПУ им.К.Минина 
Факультет информационных технологий группа 
ПИМ-22-1).
Почта для связи:maresev558@gmail.com
    ";
            MessageBox.Show(author, "Об авторе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
