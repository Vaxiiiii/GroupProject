using System;
using System.Windows;
using System.Windows.Controls;

namespace ProjectGroup
{
    /// <summary>
    /// Interaction logic for EntryPage.xaml
    /// </summary>
    public partial class EntryPage : Page
    {
        public EntryPage()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            string recipeName = RecipeNameTextBox.Text;
            string ingredients = IngredientsTextBox.Text;
            string instructions = InstructionsTextBox.Text;

            if (string.IsNullOrWhiteSpace(recipeName) || string.IsNullOrWhiteSpace(ingredients) || string.IsNullOrWhiteSpace(instructions))
            {
                MessageBox.Show("All fields must be filled out.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Here you would typically add the new recipe to your data source, such as a database or a file.
            // For the sake of this example, we'll just show a success message.
            MessageBox.Show($"Successfully added recipe: {recipeName}", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            // Clear the text boxes for the next entry.
            RecipeNameTextBox.Text = string.Empty;
            IngredientsTextBox.Text = string.Empty;
            InstructionsTextBox.Text = string.Empty;
        }
    }
}

