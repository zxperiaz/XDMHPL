﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Services.BUS;
using Services.Database;

public partial class StartFrom : System.Web.UI.Page
{
    QLCuocDTEntities qLCuocDT = new QLCuocDTEntities();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCheckPhoneNumber_Click(object sender, EventArgs e)
    {
        string phoneNumber = txtPhoneNumber.Text;
        if(phoneNumber == "")
        {
            lblNotify.Text = "Vui lòng nhập vào số điện thoại!";
        }
        else
        {
            HoaDonDK hoadon = qLCuocDT.HoaDonDKs.Where(x => x.Sim.SoSim == phoneNumber).SingleOrDefault();
            if (hoadon == null)
            {
                lblNotify.Text = "Số điện thoại không tồn tại!";
            }
            else
            {
                Session["NAMECUSTOMER"] = hoadon.KhachHang.TenKH;
                Session["MaSim"] = hoadon.Sim.MaSim.ToString();
                Server.Transfer("MainForm.aspx");
            }
        }
    }
}