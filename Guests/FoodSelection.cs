using Guests.Models;
using Guests.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guests
{
    internal partial class FoodSelection : Form
    {
        private readonly GuestModel _guestModel;
        private readonly ICategoryService _categoryService;
        private List<CategoryModel> allCategories;
        private int activeIndex = 0;
        private readonly FoodItemModel _foodItemModel;
        private readonly IfoodItemService _foodItemService;
        private List<FoodItemModel> _listFoodByCatgories;
        private BindingList<FoodItemModel> foodItemList ;
        private List<ChoiceGuestModel> _listGuestChoice;
        private readonly IChoiceGuest _choiceGuestService;
        private readonly ChoiceGuestModel _choiceGuestModel;

        public FoodSelection(GuestModel guest)
        {
            InitializeComponent();
            //Guest Initialize
            _guestModel = guest;
            GuestNameLabel.Text = guest.GuestName;

            //Category Initialize
            _categoryService = new CategoryService();
            allCategories = _categoryService.GetAllCategories();
            CategoryLabel.Text = allCategories[activeIndex].CategoryName;

            //Guest Choice Initialize
            _choiceGuestService = new GuestChoiceService();         
            _choiceGuestModel = new ChoiceGuestModel();
            _choiceGuestService.GetChoiceGuest(guest.Id);
            _listGuestChoice = [];

            //Food Item Initialize
            _foodItemService = new FoodItemService();
            _foodItemModel = new FoodItemModel();
            foodItemList = [];


            //Grid View
            //don't do a new row by automatic
            FoodItemGridView.AutoGenerateColumns = false;
            //create a new column 
            DataGridViewTextBoxColumn Name = new()
            {
                DataPropertyName = "FoodName",
                HeaderText = "Name",
            };
            FoodItemGridView.Columns.Add(Name);

            
       
            ListFoodGridView.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn foodName = new()
            {
                DataPropertyName = "FoodName",
                HeaderText = "Name",
            };
            ListFoodGridView.Columns.Add(foodName);
            GridViewByCategory();

        }


        //Button Next Page
        private void NextCategory_Button(object sender, EventArgs e)
        {            
            if (allCategories.Count - 1 > activeIndex && activeIndex >= 0)
            {
                activeIndex++;
                CategoryLabel.Text = allCategories[activeIndex].CategoryName;
                GridViewByCategory();
            }
        }


        //Button Previous page
        private void PreviousCategory_Button(object sender, EventArgs e)
        {
            if (0 < activeIndex && activeIndex <= allCategories.Count - 1)
            {
                activeIndex--;
                CategoryLabel.Text = allCategories[activeIndex].CategoryName;
                GridViewByCategory();
            }
        }


        //Grid View up
        private void GridViewByCategory()
        {

            string categoryName = CategoryLabel.Text;
            FoodItemGridView.DataSource = _foodItemService.GetFoodItemsByCategory();
            ListFoodGridView.DataSource = foodItemList;

        }

        //Button Insert to the category apperance in the grid view down
        private void AddFoodItemButton_Click(object sender, EventArgs e)
        {
            string InputfoodName = AddFoodItemTextBox.Text;
            long idCategory = allCategories[activeIndex].Id;
            
            if(string.IsNullOrEmpty(InputfoodName) ) 
            {
                MessageBox.Show("All fields must be filled");
                return;
            }

            var itemFood = _foodItemService.InsertFoodItemInCatgeory(InputfoodName, idCategory);
            if(itemFood == null)
            {
                MessageBox.Show("This item is exist already");
                return;
            }
            foodItemList.Add(itemFood);
            GridViewByCategory();
            
        }
    }
}
            





            

            
