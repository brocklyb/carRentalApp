using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryApp
{


        public partial class Form1 : Form
        {
        public class carClass
        {
            public string modelName { get; set; }
            public string manufacturerName { get; set; }
            public string carID { get; set; }

            public override string ToString()
            {
                return $"{modelName} by {manufacturerName} id= {carID}";
            }
        }


            private const string FilePath = "C:\\Users\\16232\\Desktop\\c# projects\\Library App\\LibraryApp\MOCK_DATA.json";
            private List<carClass> allCars;


            public Form1()
            {
                InitializeComponent();
                LoadCarsFromFile();
            }

            private void LoadCarsFromFile()
            {
                if (File.Exists(FilePath))
                {
                    string json = File.ReadAllText(FilePath);
                    allCars = JsonSerializer.Deserialize<List<carClass>>(json) ?? new List<carClass>;
                }
                else
                {
                    MessageBox.Show("File path not found");
                }
                /*
                private void button1_Click(object sender, EventArgs e)
                {
                    string bookToSearchFor = userInput_searchBook.Text;

                    foreach (string item in listBox_allBooks.Items)
                    {
                        if (bookToSearchFor == item)
                        {
                            MessageBox.Show(item.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Book not found");
                        }
                    }
                }
                */
            }
        }
    }}}
