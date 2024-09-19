using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sample2.Views.Products
{
    public partial class Products : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con= new Models.Functions();
            ShowProducts();

        }
        private void ShowProducts() 
        {
            string Query = "select * from ProductTbl";
            ProductsList.DataSource = Con.GetData(Query);
            ProductsList.DataBind();
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            try
            {
                if(PIdTb.Value == "" || PNameTb.Value == "" || PDescriptionTb.Value == "" || CNameTb.Value == "" || UNameTb.Value == "") 
                {
                    ErrMsg.InnerText = "Missing Data";
                }
                else 
                {
                    string Id = PIdTb.Value;
                    string Name = PNameTb.Value;
                    string Description = PDescriptionTb.Value;
                    string CName = CNameTb.Value;
                    string UName = UNameTb.Value;
                    string Query = "insert into ProductTbl values('{0}','{1}','{2}','{3}','{4}')";
                    Query = string.Format(Query, Id, Name, Description, CName, UName);
                    Con.SetData(Query);
                    ShowProducts();
                    ErrMsg.InnerText = "Product Added";
                    PIdTb.Value = "";
                    PNameTb.Value = "";
                    PDescriptionTb.Value = "";
                    CNameTb.Value = "";
                    UNameTb.Value = "";
                }
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }
        int Key = 0;
        protected void ProductsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PIdTb.Value = ProductsList.SelectedRow.Cells[1].Text;
            PNameTb.Value = ProductsList.SelectedRow.Cells[2].Text;
            PDescriptionTb.Value = ProductsList.SelectedRow.Cells[3].Text;
            CNameTb.Value = ProductsList.SelectedRow.Cells[4].Text;
            UNameTb.Value = ProductsList.SelectedRow.Cells[5].Text;
            if(PIdTb.Value == "") 
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(PIdTb.Value = ProductsList.SelectedRow.Cells[1].Text);
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PIdTb.Value == "" || PNameTb.Value == "" || PDescriptionTb.Value == "" || CNameTb.Value == "" || UNameTb.Value == "")
                {
                    ErrMsg.InnerText = "Missing Data";
                }
                else
                {
                    string Id = PIdTb.Value;
                    string Name = PNameTb.Value;
                    string Description = PDescriptionTb.Value;
                    string CName = CNameTb.Value;
                    string UName = UNameTb.Value;
                    string Query = "update ProductTbl set PName = '{0}', PDescription = '{1}', CName = '{2}', UName = '{3}' where PId = {4}";
                    Query = string.Format(Query, Name, Description, CName, UName, ProductsList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowProducts();
                    ErrMsg.InnerText = "Product Edited";
                    PIdTb.Value = "";
                    PNameTb.Value = "";
                    PDescriptionTb.Value = "";
                    CNameTb.Value = "";
                    UNameTb.Value = "";
                }
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PIdTb.Value == "" || PNameTb.Value == "" || PDescriptionTb.Value == "" || CNameTb.Value == "" || UNameTb.Value == "")
                {
                    ErrMsg.InnerText = "Missing Data";
                }
                else
                {
                    string Id = PIdTb.Value;
                    string Name = PNameTb.Value;
                    string Description = PDescriptionTb.Value;
                    string CName = CNameTb.Value;
                    string UName = UNameTb.Value;
                    string Query = "Delete from ProductTbl where PId = {0}";
                    Query = string.Format(Query, ProductsList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowProducts();
                    ErrMsg.InnerText = "Product Deleted";
                    PIdTb.Value = "";
                    PNameTb.Value = "";
                    PDescriptionTb.Value = "";
                    CNameTb.Value = "";
                    UNameTb.Value = "";
                }
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            try
            {
                if (UNameTb.Value == "")
                {
                    ErrMsg.InnerText = "Missing Data";
                }
                else
                {
                    string UName = UNameTb.Value;
                    string CName = CNameTb.Value;
                    string Query = "select * from ProductTbl where UName = {0}";
                    Query = string.Format(Query, ProductsList.SelectedRow.Cells[5].Text);
                    Con.SetData(Query);
                    ShowProducts();
                    ErrMsg.InnerText = "Product Searched";
                    UNameTb.Value = "";
                }
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }
    }
}