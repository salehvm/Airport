using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airport.Models;


namespace Airport
{
    public partial class Form1 : Form
    {

        private airportEntities1 Airpot = new airportEntities1();


        public Form1()
        {

            InitializeComponent();
            loadData();
            fillData();
        }

        private void loadData()
        {

            dgvAirportView.DataSource = Airpot.fly.Select(f => new
            {
                f.Id,
                CompanyName=f.Company.Name,
                f.type,
                f.Date,
                f.Gate.Number,
                f.Runway.stripe,
                CityName = f.City.Name,
                f.Status
                


            }).ToList();
            
        }

        private void fillData()
        {
            List<Company> company = Airpot.Company.ToList();
            foreach (Company item in company)
            {
                cbCompany.Items.Add(item.Name);
            }
            List<Country> country = Airpot.Country.ToList();
            foreach (Country item in country)
            {
                cbCountry.Items.Add(item.Name);
            }
            List<City> city = Airpot.City.ToList();
            foreach (City item in city)
            {

                cbCity.Items.Add(item.Name);
            }
            List<Gate> gates = Airpot.Gate.ToList();
            foreach (Gate item in gates)
            {
                cbGate.Items.Add(item.Number);
            }
            List<Runway> runways = Airpot.Runway.ToList();
            foreach (Runway item in runways)
            {
                cbRunway.Items.Add(item.stripe);
            }
        }
        private int getidCountry(string name)
        {
            int id = Airpot.Country.FirstOrDefault(c => c.Name == name).Id;
            return id;
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCity.Items.Clear();
            int id = getidCountry(cbCountry.Text);
            List<City> cities = Airpot.City.Where(c => c.Country_id == id).ToList();
            foreach (City item in cities)
            {
                cbCity.Items.Add(item.Name);
            }
        }

        private void btnAddflight_Click(object sender, EventArgs e)
        {
            string company = cbCompany.Text;
            int gates = Convert.ToInt32(cbGate.Text);
            int runways = int.Parse(cbRunway.Text);
            DateTime dates = dtpDate.Value;

            DateTime x30MinsLater = dates.AddMinutes(30);
            DateTime x30Minsbefor = dates.AddMinutes(-30);


            var checkflygate = Airpot.fly.Where(x => x.Date >= x30Minsbefor && x.Date <= x30MinsLater  && x.Gate.Number == gates).ToList();

            DateTime x45MinsLater = dates.AddMinutes(45);
            DateTime x45Minsbefor = dates.AddMinutes(-45);

            var checkflyrunway = Airpot.fly.Where(x => x.Date >= x45Minsbefor && x.Date <= x45MinsLater && x.Runway.stripe ==runways).ToList();







            if (checkflygate.Count > 0 || checkflyrunway.Count > 0)
            {
                if (checkflygate.Count > 0 && checkflyrunway.Count > 0)
                {
                    MessageBox.Show(cbGate.Text + " qapi ve "+cbRunway.Text+" stript doludur " );
                }
                else if (checkflygate.Count > 0)
                {
                    MessageBox.Show(cbGate.Text + " qapi ve ");
                }
                else if (checkflyrunway.Count > 0)
                {
                    MessageBox.Show(cbRunway.Text + " stript doludur ");
                }
            }
            else
            {

                fly flight = new fly();

                Gate gate = Airpot.Gate.FirstOrDefault(x => x.Number == gates);
                Company com = Airpot.Company.FirstOrDefault(x => x.Name == company);
                Runway runwayss = Airpot.Runway.FirstOrDefault(x => x.stripe == runways);
                City city = Airpot.City.FirstOrDefault(x => x.Name == cbCity.Text);
                Airports air = Airpot.Airports.Find(1);

                flight.Company = com;
                flight.Gate = gate;
                flight.Runway = runwayss;
                flight.City = city;
                flight.Date = dates;
                flight.No = "k44";
                if (rbArrival.Checked)
                {
                    flight.type = true;
                }
                else
                {
                    flight.type = false; ;
                }

                flight.Status = 1;
                flight.late = DateTime.Now;
                flight.Airportid = 1;
                flight.Airports = air;



                Airpot.fly.Add(flight);

                Airpot.SaveChanges();
                loadData();

            }





        }

    }
}
