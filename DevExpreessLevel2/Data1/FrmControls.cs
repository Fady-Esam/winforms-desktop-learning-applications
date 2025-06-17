using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1
{
    public partial class FrmControls : DevExpress.XtraEditors.XtraForm
    {
        public FrmControls()
        {
            InitializeComponent();
        }

        private void FrmControls_Load(object sender, EventArgs e)
        {
            breadCrumbEdit1.Properties.Items.Add(new BreadCrumbNode("Root", "Root Item"));
            breadCrumbEdit1.Properties.Items.Add(new BreadCrumbNode("Folder1", "Folder 1"));
            breadCrumbEdit1.Properties.Items.Add(new BreadCrumbNode("Folder2", "Folder 2"));
            breadCrumbEdit1.Properties.Items.Add(new BreadCrumbNode("File", "File.txt"));
            //tileNavPane1.tileNavCategory1 = new TileNavCategory
            //{
            //    Name = "Category1",
            //    Caption = "Category 1",
            //};

            //// Initialize TileNavItems
            //tileNavItem1 = new TileNavItem
            //{
            //    Name = "Item1",
            //    Caption = "Item 1",
            //};

            //tileNavItem2 = new TileNavItem
            //{
            //    Name = "Item2",
            //    Caption = "Item 2",
            //};

            //// Add items to category
            //tileNavCategory1.Tile.DropDownOptions.BeakColor = System.Drawing.Color.FromArgb(200, 200, 200);
            //tileNavCategory1.Tile.Items.AddRange(new[] { tileNavItem1, tileNavItem2 });

            //// Add category to TileNavPane
            //tileNavPane1.Categories.Add(tileNavCategory1);
        }
    }
}