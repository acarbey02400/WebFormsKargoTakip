using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsKargoTakip.DataAccess.Repositories;
using WebFormsKargoTakip.Model;

namespace WebFormsKargoTakip
{
    public partial class CargoDefault : System.Web.UI.Page
    {
        ICargoRepository _cargoRepository;
        public CargoDefault(ICargoRepository cargoRepository)
        {
            _cargoRepository = cargoRepository;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = _cargoRepository.GetAll();
                GridView1.DataBind();
                tblUpdateCargo.Visible = false;
                
            }
        }
        protected void btnEkle_Click(object sender, EventArgs e)
        {
            _cargoRepository.Add(new Cargo
            {
                SenderName = txtNewSenderName.Text,
                Address = txtNewAddress.Text,
                BuyerName = txtNewBuyerName.Text,
                Status = NewchkStatus.Checked
            });
            Page_Load(sender, e);
            Response.Redirect("CargoDefault.aspx");
        }
        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            _cargoRepository.Update(new Cargo
            {
                Id = Convert.ToInt32(UCargoID.Text),
                SenderName = txtUpdateSenderName.Text,
                Address = txtUpdateAddress.Text,
                BuyerName = txtUpdateBuyerName.Text,
                Status = UpdateCheckbox.Checked
            });
            Page_Load(sender, e);
            Response.Redirect("CargoDefault.aspx");
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Sil")
            {

                int id = Convert.ToInt32(e.CommandArgument);
                var result = _cargoRepository.Delete(id);
                Thread.Sleep(100);
                Response.Redirect("CargoDefault.aspx");
            }
            else if (e.CommandName == "Duzenle")
            {
                string[] arguments = e.CommandArgument.ToString().Split('|');
                UCargoID.Text = arguments[0];
                txtUpdateSenderName.Text = arguments[1];
                txtUpdateAddress.Text = arguments[3];
                txtUpdateBuyerName.Text = arguments[2];
                UpdateCheckbox.Checked = Boolean.Parse(arguments[4]);
                tblUpdateCargo.Visible = true;
                
            }
        }

    }
}