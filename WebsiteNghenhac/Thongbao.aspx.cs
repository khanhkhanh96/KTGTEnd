using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        switch ((int)Session["mathongbao"]){
            case 1: Label1.Text = "Bạn cần đăng nhập để vào trang này";
                break;
            case 2: Label1.Text = "Bạn không đủ quyền vào trang này";
                break;
            case 3: Label1.Text = "Vui lòng gặp quản lí trang để lấy lại mật khẩu";
                break;

        }
    }
}