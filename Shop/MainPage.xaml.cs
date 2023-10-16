using System;
using System.Collections.Generic;
using Microsoft.Maui.Controls;
using Shop;

namespace Shop
{
    public partial class MainPage : ContentPage
    {
        List<object> Good = new List<object>();

        Random random = new Random();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            listView.ItemsSource = Good;
        }

        private async void Add_Clicked(object sender, EventArgs e)
        {
            string userInput = await DisplayPromptAsync("Adding new good", "Type a name of your good");
            string product = userInput;
            userInput = await DisplayPromptAsync("Adding new good", "Type a price of your good(only integers are allowed)");
            int price = 0;
            if (!int.TryParse(userInput, out price))
            {
                await DisplayAlert("Alert", "Non-integer value entered", "OK");
                return;
            }
            DateTime today = DateTime.Today;
            string stringToday = today.ToString("yyyy-MM-dd");
            userInput = await DisplayPromptAsync("Adding new good", "Type date when your good was packed as in example: " + stringToday);
            DateTime date;
            if(!DateTime.TryParse(userInput, out date))
            {
                await DisplayAlert("Alert", "You should enter value as in example", "OK");
                return;
            }
            userInput = await DisplayPromptAsync("Adding new good", "Type name of country your good made in");
            string state = userInput;

            userInput = await DisplayPromptAsync("Adding new good", "Enter type of good(food/book)");
            userInput.Trim().ToLower();
            string description = "";
            if (userInput != "food" & userInput != "book")
            {
                await DisplayAlert("Alert", "Only food/book are allowed", "OK");
                return;
            }
            else
            {
                description = userInput;
            }

            if (description == "food")
            {
                int day = 0;
                userInput = await DisplayPromptAsync("Adding new good", "Type amount of days untill your food expire(only integers are allowed)");
                if (!int.TryParse(userInput, out day))
                {
                    await DisplayAlert("Alert", "Non-integer value entered", "OK");
                    return;
                }
                DateTime expiration = DateTime.Today.AddDays(day);
                string formattedExpiration = expiration.ToString("yyyy-MM-dd");
                int quantity = 0;
                userInput = await DisplayPromptAsync("Adding new good", "Type quantity of your food(only integers are allowed)");
                if (!int.TryParse(userInput, out quantity))
                {
                    await DisplayAlert("Alert", "Non-integer value entered", "OK");
                    return;
                }
                userInput = await DisplayPromptAsync("Adding new good", "Type unit of your food");
                string unit = userInput;

                Good.Insert(0, new Products
                {
                    Price = price,
                    State = state,
                    Name = product,
                    Date = date.ToString("yyyy-MM-dd"),
                    Description = description,
                    Expiration = formattedExpiration,
                    Quantity = quantity,
                    Unit = unit
                });
            }
            else
            {
                int pages = 0;
                userInput = await DisplayPromptAsync("Adding new good", "Type the number of pages your book has(only integers are allowed)");
                if (!int.TryParse(userInput, out pages))
                {
                    await DisplayAlert("Alert", "Non-integer value entered", "OK");
                    return;
                }
                userInput = await DisplayPromptAsync("Adding new good", "Type the Publisher name of your book");
                string publishing = userInput;
                userInput = await DisplayPromptAsync("Adding new good", "Type the Author name of your book");
                string author = userInput;

                Good.Insert(0, new Books
                {
                    Price = price,
                    State = state,
                    Name = product,
                    Description = description,
                    Pages = pages,
                    Author = author,
                    Publishing = publishing
                });
            }
            listView.ItemsSource = null;
            listView.ItemsSource = Good;
        }
        private void Delete_Clicked(object sender, EventArgs e)
        {
            if (listView.SelectedItem is object selectedProduct)
            {
                Good.Remove(selectedProduct);
                listView.ItemsSource = null;
                listView.ItemsSource = Good;

            }
        }
    }
}
