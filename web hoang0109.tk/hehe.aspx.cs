﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hehe : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["id"] = "admin";
        Session.Timeout = 9999;
        Response.Redirect("default2.aspx");

    }
}