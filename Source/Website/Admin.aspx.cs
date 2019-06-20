﻿using System;
using System.Web.Security;
using Tailwind.Traders.Rewards.Web.Data;
using Tailwind.Traders.Rewards.Web.Models;

namespace Tailwind.Traders.Rewards.Web
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.User.Identity.IsAuthenticated)
            {
                Label1.Text = "Logado " + Page.User.Identity.Name;
            }
            else
            {
                FormsAuthentication.RedirectToLoginPage();
            }
        }

        protected void OnClickSignout(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("Default.aspx", true);
        }

        protected void OnClickAddCustomer(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                Email = "newcustomer@customers.com",
                RowVersion = new byte[] { },
                AccountCode = "UnaAccountCode",
                FirstName = "John",
                LastName = "Doe",
                FirstAddress = "First address value",
                City = "Una city",
                Country = "Un country",
                ZipCode = "12344",
                Website = "Un website",
                Active = true,
                Enrrolled = EnrollmentStatusEnum.Uninitialized,
                PhoneNumber = "3546778",
                MobileNumber = "379839304",
                FaxNumber = "98375903"
            };

            CustomerData.AddCustomer(customer);
        }

        protected void OnClickUpdateCustomer(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                Email = "MODIFIED@customers.com",
                RowVersion = new byte[] { },
                AccountCode = "UnaAccountCode",
                FirstName = "John modified",
                LastName = "Doe",
                FirstAddress = "First address value",
                City = "Una city",
                Country = "Un country",
                ZipCode = "12344",
                Website = "Un website",
                Active = true,
                Enrrolled = EnrollmentStatusEnum.Uninitialized,
                PhoneNumber = "3546778",
                MobileNumber = "379839304",
                FaxNumber = "98375903",
                CustomerId = 11
            };

            CustomerData.UpdateCustomer(customer);
        }

        protected void OnClickDeleteCustomer(object sender, EventArgs e)
        {
            CustomerData.DeleteCustomer(1);
        }

        protected void OnClickAddOrder(object sender, EventArgs e)
        {
            var order = new Order
            {
                Code = "121344443",
                Date = DateTime.Now,
                ItemName = "Un item name",
                Type = "Un type",
                Status = "un status",
                Total = 234
            };

            OrdersData.AddOrder(order);
        }

        protected void OnClickUpdateOrder(object sender, EventArgs e)
        {
            var order = new Order
            {
                Code = "CODEMODIFIEDhjksdafhkjsdaf",
                Date = DateTime.Now,
                ItemName = "Un item name",
                Type = "Un type",
                Status = "un status",
                Total = 234,
                OrderId = 12
            };

            OrdersData.UpdateOrder(order);
        }

        protected void OnClickDeleteOrder(object sender, EventArgs e)
        {
            OrdersData.DeleteOrder(1);
        }
    }
}