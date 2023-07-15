using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsKargoTakip.DataAccess.Repositories;
using WebFormsKargoTakip.Model;

namespace WebFormsKargoTakip
{
    public partial class _Default : Page
    {
        IUserRepository _userRepository;
        public _Default(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // Giriş yap butonuna tıklandığında çalışacak kodlar buraya gelebilir.
            string username = txtUsername.Value;
            string password = txtPassword.Value;

            if (_userRepository.Get(p => p.UserName == username && p.Password == password) != null)
            {
                lblErrorMessage.CssClass = "success-message";
                lblErrorMessage.ForeColor = System.Drawing.Color.DarkGreen;
                lblErrorMessage.Text = "Giriş başarılı.";
                Response.Redirect("CargoDefault.aspx");
            }

            // Giriş başarılı ise başka bir sayfaya yönlendirme yapabilirsiniz. 
            else
            {
                // Giriş başarısız ise hata mesajını gösterebilirsiniz.
                lblErrorMessage.CssClass = "error-message";
                lblErrorMessage.ForeColor = System.Drawing.Color.Red;
                lblErrorMessage.Text = "Geçersiz kullanıcı adı veya şifre.";
            }
        }
    }
}