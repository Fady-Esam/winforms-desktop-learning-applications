using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskProject;

namespace resGUI
{
    public partial class ExtractsFrm : DevExpress.XtraEditors.XtraForm
    {
        DBClass dbObj = new DBClass();
        public ExtractsFrm()
        {
            InitializeComponent();
        }

        private void ExtractsFrm_Load(object sender, EventArgs e)
        {
            
            /*string query = @"SELECT proj.ProjectName, proj.CustomerID, proj.StartDate, 
            proj.IsActive, proj.Status, proj.IsFinished, extTax.TaxRate, ext.ExtractSerial, ext.ExtractType,
            taxVal.TaxName, taxVal.TaxSymbol, taxVal.ChangeRate, taxVal.TaxEffict, taxVal.ChartAccount,
            extDet.Qty, extDet.ItemPrice, extDet.DonePerc, extDet.GuaranteeDiscountPerc, 
            extDet.GuaranteeDiscountAmount, projItem.ItemPackage
            FROM ContractingProjectsTbl proj INNER JOIN ContractingExtractsTbl ext 
            ON proj.ProjectID = ext.ProjectID INNER JOIN ContractingProjectItemsTbl projItem 
            ON proj.ProjectID = projItem.ProjectID INNER JOIN ContractingExtractDetailsTbl extDet 
            ON ext.ExtractID = extDet.ExtractID INNER JOIN ContractingExtTaxTbl extTax 
            ON ext.ExtractID = extTax.ExtractID INNER JOIN TaxesValuesTbl taxVal 
            ON extTax.TaxID = taxVal.TaxID";*/






            

            string query = @"  
            SELECT proj.ProjectName, proj.CustomerID, proj.StartDate, 
                   proj.IsActive, proj.Status, proj.IsFinished, extTax.TaxRate, ext.ExtractSerial, ext.ExtractType,
                   taxVal.TaxName, taxVal.TaxSymbol, taxVal.ChangeRate, taxVal.TaxEffict, taxVal.ChartAccount,
                   extDet.Qty, extDet.ItemPrice, extDet.DonePerc,
                   (extDet.Qty * extDet.ItemPrice * (extDet.DonePerc / 100.0) * (extDet.GuaranteeDiscountPerc / 100.0)) AS GuaranteeDiscountAmount,
                   projItem.ItemPackage
            FROM ContractingProjectsTbl proj
            INNER JOIN ContractingExtractsTbl ext 
                ON proj.ProjectID = ext.ProjectID
            INNER JOIN ContractingExtractDetailsTbl extDet 
                ON ext.ExtractID = extDet.ExtractID
            INNER JOIN ContractingProjectItemsTbl projItem 
                ON proj.ProjectID = projItem.ProjectID
            INNER JOIN ContractingExtTaxTbl extTax 
                ON ext.ExtractID = extTax.ExtractID
            INNER JOIN TaxesValuesTbl taxVal 
                ON extTax.TaxID = taxVal.TaxID;
            ";
            gridControl2.DataSource = dbObj.dataget(query, "get");
            /*
            string query2 = @"
            WITH LatestProject AS (
                SELECT TOP 1 proj.ProjectID
                FROM ContractingProjectsTbl proj
                ORDER BY proj.ProjectID DESC
            )
            SELECT proj.ProjectName, proj.CustomerID, proj.StartDate, 
                   proj.IsActive, proj.Status, proj.IsFinished, ext.ExtractSerial, ext.ExtractType, 
                   extDet.Qty, extDet.ItemPrice, extDet.DonePerc, extDet.GuaranteeDiscountPerc, 
                   extDet.GuaranteeDiscountAmount, projItem.ItemPackage
            FROM ContractingProjectsTbl proj 
            INNER JOIN ContractingExtractsTbl ext 
                ON proj.ProjectID = ext.ProjectID 
            INNER JOIN ContractingExtractDetailsTbl extDet 
                ON ext.ExtractID = extDet.ExtractID

            INNER JOIN LatestProject lp
                ON proj.ProjectID = lp.ProjectID";

            string taxQuery = @"SELECT ext.ExtractSerial, extTax.TaxRate, taxVal.TaxName, 
            taxVal.TaxSymbol, taxVal.ChangeRate, taxVal.TaxEffict, taxVal.ChartAccount 
            FROM ContractingExtTaxTbl extTax INNER JOIN TaxesValuesTbl taxVal 
            ON extTax.TaxID = taxVal.TaxID INNER JOIN ContractingExtractsTbl ext
            ON extTax.ExtractID = ext.ExtractID";

            string taxQuery2 = @"WITH LatestProject AS (
                    SELECT TOP 1 ProjectID
                    FROM ContractingProjectsTbl
                    ORDER BY ProjectID DESC  
                )
                SELECT ext.ExtractSerial, extTax.TaxRate, taxVal.TaxName, 
                        taxVal.TaxSymbol, taxVal.ChangeRate, taxVal.TaxEffict, taxVal.ChartAccount 
                FROM ContractingExtTaxTbl extTax
                INNER JOIN TaxesValuesTbl taxVal 
                    ON extTax.TaxID = taxVal.TaxID
                INNER JOIN ContractingExtractsTbl ext
                    ON extTax.ExtractID = ext.ExtractID
                INNER JOIN ContractingProjectsTbl proj
                    ON ext.ProjectID = proj.ProjectID
                INNER JOIN LatestProject lp
                    ON proj.ProjectID = lp.ProjectID;
                ";
            // gridControl1.DataSource = dbObj.dataget(taxQuery2, "get");*/
        }
    }
}





//INNER JOIN ContractingProjectItemsTbl projItem 
   //         ON extDet.ItemID = projItem.ItemID

