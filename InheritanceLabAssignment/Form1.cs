/* Ana Carolina de Souza Mendes
 * Cornell Coulon
 * 
 * April 16, 2018
 * 
 * Inheritance Lab Assignment
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarLib;
using MetroFramework;

namespace InheritanceLabAssignment
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        //**************************GLOBAL VARIABLES*************************
        //list to hold all the 30 Car objects
        List<Car> carList = new List<Car>();
        //sublists to hold 10 Car objects of each type
        List<Car> pCars = new List<Car>();
        List<SportCar> pSportCars = new List<SportCar>();
        List<Truck> pTrucks = new List<Truck>();
        List<Car> filter3 = new List<Car>();
        //**************************FORM 1***********************************
        public Form1()
        {
            InitializeComponent();
        }
        //**************************FORM LOAD********************************
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            //populate sublists
            PopulateCarList(pCars);
            PopulateSportCarList(pSportCars);
            PopulateTruckList(pTrucks);
            //genarate random customerIDs
            List<int> customerList = GenerateCustomers(rand);
            //populate carList (30 Car objects)
            SortCarList(rand, customerList, carList, pCars, pSportCars, pTrucks);
            //populate comboboxes
            PopulateComboBoxes(carList);
            //empty label
            lblTotalPrice.Text = String.Empty;
            //setting filter3 to carList
            filter3 = carList;
        }
        //**************************METHODS**********************************
        //methods to populate the sublists
        private void PopulateCarList(List<Car> c)
        {
            Car c1 = new Car("BMW","3 Series",2011,28000,"2.0L V4",24);
            Car c2 = new Car("Mercedes","C class",2016,35000,"3.0L V6",22);
            Car c3 = new Car("Mazda","3 Series",2010,26000,"3.0L V6",22);
            Car c4 = new Car("Infinity","G35",2013,30000,"3.0L V6",20);
            Car c5 = new Car("Honda","Civic",2018,29000,"2.0L V4",32);
            Car c6 = new Car("Toyota","Camry",2013,35000,"3.5L V8",21);
            Car c7 = new Car("Chevrolet","Malibu",2018,20000,"2.5L V4",25);
            Car c8 = new Car("Toyota","Corolla",2013,20000,"2.5L V4",40);
            Car c9 = new Car("BMW","XR5",2018,35000,"2.5L V4",51);
            Car c10 = new Car("Audi","A3",2018,30000,"2.5L V4",44);

            c.Add(c1);
            c.Add(c2);
            c.Add(c3);
            c.Add(c4);
            c.Add(c5);
            c.Add(c6);
            c.Add(c7);
            c.Add(c8);
            c.Add(c9);
            c.Add(c10);
        }
        private void PopulateSportCarList(List<SportCar> sc)
        {
            SportCar sc1 = new SportCar("BMW","M5",2013,120000,"3.0L V6",18,3.03);
            SportCar sc2 = new SportCar("Mercedes","AMG GT",2013,110000,"3.0L V8",16,2.02);
            SportCar sc3 = new SportCar("Jaguar","F-TYPE",2017,66000,"4.0L V8",14,3.27);
            SportCar sc4 = new SportCar("Porche","911",2015,92000,"4.0L V8",13,1.7);
            SportCar sc5 = new SportCar("Acura","NSX",2018,167000,"2.5L V6",18,3.59);
            SportCar sc6 = new SportCar("Nissan","GT-R",2017,105000,"3.2L V6",14,2.51);
            SportCar sc7 = new SportCar("Chevrolet","Corvette",2016,70000,"3.0L V8",18,2.6);
            SportCar sc8 = new SportCar("Toyota","86",2017,28000,"2.5L V6",17,3.27);
            SportCar sc9 = new SportCar("BMW","I8",2015,150000,"3.0L V8",17,1.7);
            SportCar sc10 = new SportCar("Audi","R8",2014,69000,"4.0L V8",13,2);

            sc.Add(sc1);
            sc.Add(sc2);
            sc.Add(sc3);
            sc.Add(sc4);
            sc.Add(sc5);
            sc.Add(sc6);
            sc.Add(sc7);
            sc.Add(sc8);
            sc.Add(sc9);
            sc.Add(sc10);
        }
        private void PopulateTruckList(List<Truck> t)
        {
            Truck t1 = new Truck("Ford","F-150",2010,29000,"4.6L V8",19,9000);
            Truck t2 = new Truck("Chevrolet","Silverado 2500",2013,28000,"5.4L V8",20,16000);
            Truck t3 = new Truck("Honda","Ridgeline 2WD",2018,21000,"4.6L V6",19,9000);
            Truck t4 = new Truck("Dodge","RAM 1500",2016,22000,"4.6L V8",19,9000);
            Truck t5 = new Truck("GMC","1500",2016,26000,"4.6L V8",18,9000);
            Truck t6 = new Truck("Ford","F-250",2013,28000,"5.4L V8",18,16000);
            Truck t7 = new Truck("Chevrolet","Silverado 1500",2013,15000,"4.6L V8",20,9000);
            Truck t8 = new Truck("Honda","Ridgeline 4WD",2015,30000,"5.4L V6",18,16000);
            Truck t9 = new Truck("Dodge","2500",2013,30000,"5.4L V8",18,16000);
            Truck t10 = new Truck("GMC","2500",2013,17000,"5.4L V8",20,16000);

            t.Add(t1);
            t.Add(t2);
            t.Add(t3);
            t.Add(t4);
            t.Add(t5);
            t.Add(t6);
            t.Add(t7);
            t.Add(t8);
            t.Add(t9);
            t.Add(t10);
        }
        //method to generate random customerIDs
        private List<int> GenerateCustomers(Random rand)
        {
            List<int> customers = new List<int>();
            //loop to generate 20 customerIDs
            for (int i = 0; i < 20; i++)
            {
                int c = rand.Next(1000, 10000);
                //add the very first customerID
                if (i == 0)
                {
                    customers.Add(c);
                }
                else
                {
                    //check if generated customerID already exists in the list
                    foreach (int cust in customers)
                    {
                        if (cust == c)
                        {
                            //subtract from i to garantee 20 customerIDs
                            i--;
                            break;
                        }
                        else
                        {
                            //add customerID
                            customers.Add(c);
                            break;
                        }
                    }
                }
            }
            return customers;
        }
        //method to randomly populate the list of all Car objects
        private void SortCarList(Random rand, List<int> customers, 
            List<Car> cList, List<Car> c, List<SportCar> sc, List<Truck> t)
        {
            //cList is the list that holds all Car objects
            for (int i = 0; i < 30; i++)
            {
                //randomly generates the index of the customer that will be 
                //added to the Car object. It pulls the information from 
                //the customers List
                int cIndex = rand.Next(0, customers.Count);
                //randomly generates the mileage
                int mileage = rand.Next(0, 10000);
                //randomly generate the option to get Car, SportCar, or Truck
                int option = rand.Next(1, 4);
                //switch that holds the options for each type
                switch (option)
                {
                    case 1: //case Car list
                        //if we don't have any more Cars to pick from the list
                        //reduce i and go back to loop
                        if (c.Count == 0)
                        {
                            i--;
                        }
                        else
                        {
                            //randomly generates index for car list
                            int index = rand.Next(0, c.Count);
                            c[index].Mileage = mileage;
                            //randomly generates a price for Car
                            c[index].Price = rand.Next(1000, 9000);
                            c[index].CustomerID = customers[cIndex];
                            //add Car to the general list 
                            cList.Add(c[index]);
                            //remove object from car list
                            c.Remove(c[index]);
                        }
                        break;
                    case 2: //car SportCar list
                        //if we don't have any more SportCars to pick from 
                        //the list reduce i and go back to loop
                        if (sc.Count == 0)
                        {
                            i--;
                        }
                        else
                        {
                            //randomly generates index for SportCar list
                            int index = rand.Next(0, sc.Count);
                            sc[index].Mileage = mileage;
                            //randomly generates a price for SportCar
                            sc[index].Price = rand.Next(68000, 150000);
                            sc[index].CustomerID = customers[cIndex];
                            //add SportCar to the general list 
                            cList.Add(sc[index]);
                            //remove object from SportCar list
                            sc.Remove(sc[index]);
                        }
                        break;
                    case 3: //list pTrucks
                        //if we don't have any more Trucks to pick from 
                        //the list reduce i and go back to loop
                        if (t.Count == 0)
                        {
                            i--;
                        }
                        else
                        {
                            //randomly generates index for Truck list
                            int index = rand.Next(0, t.Count);
                            t[index].Mileage = mileage;
                            //randomly generates a price for Truck
                            t[index].Price = rand.Next(1000, 9000);
                            t[index].CustomerID = customers[cIndex];
                            //add Truck to the general list 
                            cList.Add(t[index]);
                            //remove object from Truck list
                            t.Remove(t[index]);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        //method to populate the comboboxes
        private void PopulateComboBoxes(List<Car> cList)
        {
            foreach (Car c in cList)
            {
                //if Make is not already in combobox, add item to it
                if(!cboMake.Items.Contains(c.Make))
                { cboMake.Items.Add(c.Make); }
                //if customerID is not already in combobox, add item to it
                if (!cboCustomerID.Items.Contains(c.CustomerID))
                { cboCustomerID.Items.Add(c.CustomerID); }
                //if Type is not already in combobox, add item to it
                if (!cboType.Items.Contains(c.GetType().Name))
                { cboType.Items.Add(c.GetType().Name); }
            }
            //organize items in alphabetical order
            cboMake.Sorted = true;
            cboCustomerID.Sorted = true;
            cboType.Sorted = true;
        }
        //method to display Car objects in listview
        private void DisplayCars(List<Car> cList) 
        {
            //clear items in listview
            listView1.Items.Clear();
            //create ListViewItem to hold rows
            ListViewItem lvi = null;
            //loop to go through general Car object list
            foreach (Car c in cList)
            {
                if (c is SportCar)
                {
                    //cast c to a SportCar object
                    SportCar sc = (SportCar)c;
                    //create a listviewitem (one row in a listview)
                    string[] item = { sc.CustomerID.ToString(), sc.Make, sc.Model, sc.Mileage.ToString(),
                                  sc.Year.ToString(), sc.Price.ToString("c"), sc.EngineSize,
                                  sc.AverageMpg.ToString(), sc.ZeroToSixty.ToString(), "-", sc.GetType().Name};
                    lvi = new ListViewItem(item);
                }
                else if (c is Truck)
                {
                    //cast c to a Truck object
                    Truck t = (Truck)c;
                    //create a listviewitem (one row in a listview)
                    string[] item = { t.CustomerID.ToString(), t.Make, t.Model, t.Mileage.ToString(),
                                  t.Year.ToString(), t.Price.ToString("c"), t.EngineSize,
                                  t.AverageMpg.ToString(), "-", t.MaxTowing.ToString(),t.GetType().Name};
                    lvi = new ListViewItem(item);
                }
                else
                {
                    //create a listviewitem (one row in a listview)
                    string[] item = { c.CustomerID.ToString(), c.Make, c.Model, c.Mileage.ToString(),
                                  c.Year.ToString(), c.Price.ToString("c"), c.EngineSize,
                                  c.AverageMpg.ToString(), "-", "-",c.GetType().Name};
                    lvi = new ListViewItem(item);
                }
                //add the row to listview
                listView1.Items.Add(lvi);
            }
        }
        //method to get the most expensive car in Car object list
        private Car GetMostExpensiveCar(List<Car> cList)
        {
            //set mostExpensive car as the first in the list
            Car mostExpensive = cList[0];
            //for loop to compare mostExpensive car to all Cars in list
            for (int i = 0; i < cList.Count; i++)
            {
                if(cList[i].Price > mostExpensive.Price)
                {
                    mostExpensive = cList[i];
                }
            }
            return mostExpensive;
        }
        //method to get the least expensive car in Car object list
        private Car GetLeastExpensiveCar(List<Car> cList)
        {
            //set mostExpensive car as the first in the list
            Car leastExpensive = cList[0];
            //for loop to compare mostExpensive car to all Cars in list
            for (int i = 0; i < cList.Count; i++)
            {
                if (cList[i].Price < leastExpensive.Price)
                {
                    leastExpensive = cList[i];
                }
            }
            return leastExpensive;
        }
        //method to filter Car objects based on Make
        private List<Car> GetCarsByMake(string make, List<Car> cList)
        {
            //list of Cars to hold objects filtered by Make
            List<Car> filterMake = new List<Car>();
            for (int i = 0; i < cList.Count; i++)
            {
                if (cList[i].Make == make)
                {
                    filterMake.Add(cList[i]);
                }
            }
            return filterMake;
        }
        //method to filter Car objects based on customerID
        private List<Car> GetCarsByCustomerID(int customerID, List<Car> filter1)
        {
            //list of Cars to hold objects filtered by customerID
            List<Car> filterCustomer = new List<Car>();
            for (int i = 0; i < filter1.Count; i++)
            {
                if (filter1[i].CustomerID == customerID)
                {
                    filterCustomer.Add(filter1[i]);
                }
            }
            return filterCustomer;
        }
        //method to filter Car objects based on Type
        private List<Car> GetCarsByType(string type, List<Car> filter2)
        {
            //decimal to hold Car object price
            decimal totalPrice = 0;
            //list of Cars to hold objects filtered by Type
            List<Car> filterType = new List<Car>();
            for (int i = 0; i < filter2.Count; i++)
            {
                if (filter2[i].GetType().Name == type)
                {
                    filterType.Add(filter2[i]);
                    totalPrice += filter2[i].Price;
                }
            }
            //Print total price on label
            lblTotalPrice.Text = totalPrice.ToString("c");
            return filterType;
        }
        //**************************EVENTS***********************************
        private void btnDisplayCars_Click(object sender, EventArgs e)
        {
            DisplayCars(carList);
        }
        private void btnMostExpensiveCar_Click(object sender, EventArgs e)
        {
            //list that will hold the most expensive Car object
            //although it's only one item, the DisplayCars method gets
            //a List<Car> and a parameter
            List<Car> mostExpensiveList = new List<Car>();
            //call method GetMostExpensiveCar and add return to list
            mostExpensiveList.Add(GetMostExpensiveCar(carList));
            //Display most expensive Car
            DisplayCars(mostExpensiveList);
        }
        private void btnFilters_Click(object sender, EventArgs e)
        {
            //Lists that holds items sorted by each filter
            //filter by Make
            List<Car> filter1 = new List<Car>();
            //filter by CustomerID
            List<Car> filter2 = new List<Car>();
            //conditional statements to call methods according to options
            //in comboboxes
            if(cboMake.Text == String.Empty)
            { filter1 = carList; }
            else
            { filter1 = GetCarsByMake(cboMake.Text, carList); }
            if(cboCustomerID.Text == String.Empty)
            { filter2 = filter1; }
            else
            { filter2 = GetCarsByCustomerID(Convert.ToInt32(cboCustomerID.Text), filter1); }
            if(cboType.Text == String.Empty)
            { filter3 = filter2; }
            else
            { filter3 = GetCarsByType(cboType.Text, filter2); }
            //display list
            DisplayCars(filter3);
            //clear comboboxes
            cboMake.SelectedIndex = -1;
            cboCustomerID.SelectedIndex = -1;
            cboType.SelectedIndex = -1;
        }
        private void btnLeastExpensive_Click(object sender, EventArgs e)
        {
            //list that will hold the least expensive Car object
            //although it's only one item, the DisplayCars method gets
            //a List<Car> and a parameter
            List<Car> leastExpensiveList = new List<Car>();
            //call method GetLeastExpensiveCar and add return to list
            leastExpensiveList.Add(GetLeastExpensiveCar(carList));
            //Display most expensive Car
            DisplayCars(leastExpensiveList);
        }
        private void btnChangePrice_Click(object sender, EventArgs e)
        {
            if (txtNewPrice.Text == String.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "You must enter a price!!!!!", "Warning!", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
            }
            else
            {
                if(listView1.SelectedIndices[0] != -1)
                {
                    //get index from selected item in listview
                    int index = listView1.SelectedIndices[0];
                    //get price from textbox
                    decimal newPrice = Convert.ToDecimal(txtNewPrice.Text);
                    //update price from selected Car
                    filter3[index].ChangePrice(newPrice);
                    //display list
                    DisplayCars(filter3);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "You must select a Car!", "Warning!", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
                }
            }
            
        }
    }
}
