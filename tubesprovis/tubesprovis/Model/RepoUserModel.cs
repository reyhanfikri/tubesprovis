using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace tubesprovis.Model
{
    public class RepoUserModel
    {
        public UserModel Authenticate(LoginModel login)
        {
            UserModel user = new UserModel();
            var listcustomer = new List<tb_Customer.Cust_Class>();
            var repositorycust = new tb_Customer.Cust_Repo();

            try
            {
                listcustomer = repositorycust.getAllCustomer();
                if (listcustomer == null)
                {
                    user.Username = "mario";
                    user.Email = "mario@whatever.gmail.com";
                }
                else
                {
                    foreach (var item in listcustomer)
                    {
                        if (item.Username == login.Username)
                        {
                            if (item.Password == login.Password)
                            {

                                user.Username = item.Username;
                                user.Id_cust = item.Id_cust;
                                user.Nama_cust = item.Nama_cust;
                                user.Email = item.Email;
                            }
                        }
                    }
                }
                

            }
            catch (Exception ex)
            {
                
            }
            
            return user;
        }

    }
}
