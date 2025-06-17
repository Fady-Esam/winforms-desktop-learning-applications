using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraReports.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Utils.Drawing.Helpers.NativeMethods;

namespace WFs
{
    public partial class GridDataFrm : DevExpress.XtraEditors.XtraForm
    {

        DataTable table;
        DataTable TaxDataTable;
        const decimal MaxValue = 25000;
        public GridDataFrm(DataTable dt, DataTable tax)
        {
            InitializeComponent();
            table = dt;
            TaxDataTable = tax;
        }
        private void TableAndData()
        {
            table.Columns.Add("TaxName", typeof(string));
            table.Columns.Add("TaxValue", typeof(decimal));
            table.Columns.Add("TaxEffect", typeof(int));
            table.Columns.Add("InvoiceNum", typeof(int));
            table.Columns.Add("TotalPrice", typeof(decimal));
            DataTable dt = DivideQtys(table);
            FetchInvioceNums(dt);
            gridControl1.DataSource = dt;
        }
        
        private DataTable DivideQtys(DataTable tbl)
        {
            DataTable dividedQtysTbl = tbl.Clone();
            for(int i = 0; i < tbl.Rows.Count; i++)
            {
                int qty = Convert.ToInt32(tbl.Rows[i]["Qty"]);
                for (int j = 0; j < qty; j++)
                {
                    if (TaxDataTable == null || table.Rows.Count == 0)
                    {
                        dividedQtysTbl.Rows.Add(
                            tbl.Rows[i]["ProductPackageID"],
                            tbl.Rows[i]["Qty"] = 1,
                            tbl.Rows[i]["Price"],
                            tbl.Rows[i]["SaleCurrency"],
                            tbl.Rows[i]["SaleCurrRate"],
                            tbl.Rows[i]["StoreID"],
                            tbl.Rows[i]["DiscountPrg"],
                            tbl.Rows[i]["SupplyDate"],
                            tbl.Rows[i]["CostAmount"],
                            "",
                            0,
                            0,
                            tbl.Rows[i]["TotalPrice"] = 1 * Convert.ToDecimal(tbl.Rows[i]["Price"])
                        );

                    }
                    else
                    {
                        dividedQtysTbl.Rows.Add(
                            tbl.Rows[i]["ProductPackageID"],
                            tbl.Rows[i]["Qty"] = 1,
                            tbl.Rows[i]["Price"],
                            tbl.Rows[i]["SaleCurrency"],
                            tbl.Rows[i]["SaleCurrRate"],
                            tbl.Rows[i]["StoreID"],
                            tbl.Rows[i]["DiscountPrg"],
                            tbl.Rows[i]["SupplyDate"],
                            tbl.Rows[i]["CostAmount"],
                            TaxDataTable.Rows[i]["TaxName"],
                            TaxDataTable.Rows[i]["TaxValue"],
                            TaxDataTable.Rows[i]["TaxEffect"],
                            tbl.Rows[i]["TotalPrice"] = 1 * Convert.ToDecimal(tbl.Rows[i]["Price"]) * ((Convert.ToDecimal(TaxDataTable.Rows[i]["TaxValue"]) * Convert.ToInt32(TaxDataTable.Rows[i]["TaxEffect"]) + 100) / 100)
                        );
                    }

                    if (tbl.Rows[i]["TotalPrice"] != null && tbl.Rows[i]["TotalPrice"] != DBNull.Value)
                    {
                        if (Convert.ToDecimal(tbl.Rows[i]["TotalPrice"]) >= MaxValue)
                        {
                            MessageBox.Show($"الاجمالي يجب الا يزيد عن {MaxValue}");
                            return new DataTable();
                        }

                    }
                }
            }
            return ProcessRows(dividedQtysTbl);
        }

        private DataTable ProcessRows(DataTable tbl)
        {
            DataTable newTable = tbl.Clone();
            decimal tot = 0;
            int qty = 0;
            for(int i = 0; i < tbl.Rows.Count; i++)
            {
                if (tot < MaxValue)
                {
                    qty++;
                }
                else
                {
                    newTable.Rows.Add(
                        tbl.Rows[i]["ProductPackageID"],
                        tbl.Rows[i]["Qty"] = qty,
                        tbl.Rows[i]["Price"],
                        tbl.Rows[i]["SaleCurrency"],
                        tbl.Rows[i]["SaleCurrRate"],
                        tbl.Rows[i]["StoreID"],
                        tbl.Rows[i]["DiscountPrg"],
                        tbl.Rows[i]["SupplyDate"],
                        tbl.Rows[i]["CostAmount"],
                        tbl.Rows[i]["TaxName"],
                        tbl.Rows[i]["TaxValue"],
                        tbl.Rows[i]["TaxEffect"],
                        tbl.Rows[i]["TotalPrice"] = tot
                    );
                }
                if (tbl.Rows[i]["TotalPrice"] != null && tbl.Rows[i]["TotalPrice"] != DBNull.Value)
                {
                    tot += Convert.ToDecimal(tbl.Rows[i]["TotalPrice"]);
                }
            }
            return newTable;
        }


        
        private void FetchInvioceNums(DataTable dt)
        {
            for (int i = 0, k = 0; i < dt.Rows.Count; i++)
            {
                if (!IsExists(i, dt))
                {
                    decimal total = 0;
                    int currentInvoiceNum = 0;
                    for (int j = i; j < dt.Rows.Count; j++)
                    {
                        object invoiceNumValue = dt.Rows[j]["InvoiceNum"];
                        decimal currentTotalPrice = (decimal)dt.Rows[j]["TotalPrice"];
                        total += currentTotalPrice;
                        if (total < MaxValue && (invoiceNumValue == DBNull.Value || invoiceNumValue == null))
                        {
                            if (currentInvoiceNum == 0)
                            {
                                currentInvoiceNum = ++k;
                            }
                            dt.Rows[j]["InvoiceNum"] = currentInvoiceNum;
                        }
                        else
                        {
                            total -= currentTotalPrice;
                        }
                    }

                }
            }
        }

        private bool IsExists(int end, DataTable dt)
        {
            for (int i = 0; i < end; i++)
            {
                if (dt.Rows[i]["InvoiceNum"] != DBNull.Value && dt.Rows[i]["InvoiceNum"] != null && dt.Rows[end]["InvoiceNum"] != DBNull.Value && dt.Rows[end]["InvoiceNum"] != null)
                {
                    if (Convert.ToDecimal(dt.Rows[i]["InvoiceNum"]) == Convert.ToDecimal(dt.Rows[end]["InvoiceNum"]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        private void GridDataFrm_Load(object sender, EventArgs e)
        {
            TableAndData();
        }

    }


}