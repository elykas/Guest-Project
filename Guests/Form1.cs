using Guests.Models;
using Guests.Service;

namespace Guests
{
    public partial class Form1 : Form
    {
        private readonly IGuestService _guestService;
        public Form1()
        {
            InitializeComponent();
            _guestService = new GuestService();
            UpdateGuests();
            GuestModel gmodel = new GuestModel();


        }


        //func to show all thr guests in the box list
        private void UpdateGuests()
        {
            GuestsListBox.DataSource = _guestService .GetAllGuests();//DataSource used to set the data that the control will display
            GuestsListBox.DisplayMember = "GuestName";//DisplayMember used to display the name propety and not the whole object
        }


        //function to add a guest by click the add button
        private void OnAddClick(object sender, EventArgs e)
        {
            string GuestInput = EnterGuestNameTextBox.Text;
            
            //check if the textbox of the name isn't empty
            if (string.IsNullOrEmpty(GuestInput))
            {
                MessageBox.Show("All fields must be filled");
                return;
            }

            //
            GuestModel? newGuest = _guestService.InsertIfNotExists(GuestInput);
            //check if the InsertIfNotExists doesn't reurn null
            //if exist the InsertIfNotExists suppose to return null
            if (newGuest == null)
            {
                MessageBox.Show("exists already");
                return;
            }
            MessageBox.Show("guest was inserted succefully");
            UpdateGuests();

        }


        //choose the guestes by a letter input
        private void OnGuestTextBoxChange(object sender, EventArgs e)
        {
            string guestInput = EnterGuestNameTextBox.Text;
            GuestsListBox.DataSource = _guestService.FindByLetters(guestInput);

        }

        
        //Ok button , show the object selected and bring you to the page of selection food
        private void OnApproveClicked(object sender, EventArgs e)
        {
            var model = GuestsListBox.SelectedValue;
            MessageBox.Show($"you choosed {model}");
            //It is used to check if the model object is of type GuestModel and,
            //if so, it assigns the casted object to a new variable guest
            if (model is GuestModel guest)
            {
                //by the ok we open a new page
                FoodSelection foodSelection = new FoodSelection(guest);//we send the gust like a parameter to the next page 
                foodSelection.Show();
                Hide();//hide the page we were
            }
        }





        private void GuestsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
