using System;
using System.Collections.Generic;
using System.Linq;
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
            GridView1.DataSource = _userRepository.GetAll();

            // Binding
            GridView1.DataBind();
        }
    }
}