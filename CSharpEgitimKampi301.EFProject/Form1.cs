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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities1 db = new EgitimKampiEfTravelDbEntities1();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            var values = db.Guide.ToList();
            dataGridView1.DataSource = values;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide();
            guide.GuideName = textName.Text;
            guide.GuideSurname = textSurname.Text;
            db.Guide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla eklendi");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textId.Text);
            var removeValue = db.Guide.Find(id);
            db.Guide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber Eklendi");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textId.Text);
            var updateValue = db.Guide.Find(id);
            updateValue.GuideName = textName.Text;
            updateValue.GuideSurname = textSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla güncellendi","Uyarı",MessageBoxButtons. OK, MessageBoxIcon.Information);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textId.Text);
            var values = db.Guide.Where(x=>x.GuideId == id).ToList();
            dataGridView1.DataSource= values;

        }
    }
}
