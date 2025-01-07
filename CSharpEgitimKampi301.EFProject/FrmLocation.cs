using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities1 db = new EgitimKampiEfTravelDbEntities1();   

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Location.ToList();
            dataGridView1.DataSource = values;

        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values=db.Guide.Select(x => new
            {
                FullName=x.GuideName+ " " + x.GuideSurname,
                x.GuideId
            }).ToList();   
            cmbGuide.DisplayMember = "FullName";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Capacity = byte.Parse(nudCapacity.Value.ToString()); 
            location.City=textCity.Text;
            location.Country=textCountry.Text;
            location.Price=decimal.Parse(textPrice.Text);
            location.DayNight=textDayNight.Text;
            location.GuideId=int.Parse(cmbGuide.SelectedValue.ToString());
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarılı");




        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id=int.Parse(textId.Text);
            var deletesValue = db.Location.Find(id);
            db.Location.Remove(deletesValue);
            db.SaveChanges() ;
            MessageBox.Show("Silme İşlemi Başarılı");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textId.Text);
            var updatesValue = db.Location.Find(id);
            updatesValue.DayNight = textDayNight.Text;
            updatesValue.Price = decimal.Parse(textPrice.Text);
            updatesValue.Capacity=byte.Parse(nudCapacity.Value.ToString());
            updatesValue.City=textCity.Text;
            updatesValue.Country=textCountry.Text;
            updatesValue.GuideId=int.Parse(cmbGuide.SelectedValue.ToString()) ;
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarılı");
        }
    }
}
