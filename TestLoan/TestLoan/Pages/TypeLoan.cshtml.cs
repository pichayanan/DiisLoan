using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Oracle.ManagedDataAccess.Client;

namespace TestLoan.Pages
{
    public class TypeLoanModel : PageModel
    {
        

        [BindProperty]
        public String LoanName { get; set; }
        [BindProperty]
        public String remain_loan { get; set; }
        [BindProperty]
        public string periods { get; set; } 
        [BindProperty]
        public String Increase { get; set; }
        [BindProperty]
        public String ID { get; set; }

        public void OnGet()
        {
            using (OracleConnection con = new OracleConnection(TestLoan.Program.conStringUser))
            {
                using (OracleCommand cmd = con.CreateCommand())
                {
                    try
                    {
                        con.Open();
                        Console.WriteLine("Successfully connected to Oracle Database as Contrac ");
                        Console.WriteLine();

                        //Retrieve sample data
                        cmd.CommandText = "select LOANNAME from LOAN where ID=1";
                        OracleDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            LoanName = reader.GetString(0).ToString();
                        }
                        reader.Dispose();
                        cmd.CommandText = "select INCREASE from LOAN where ID=1";
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Increase = reader.GetString(0).ToString();
                        }
                        reader.Dispose();
                        cmd.CommandText = "select PERIODS from LOAN where ID=1";
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            periods = reader.GetString(0).ToString();
                        }
                        reader.Dispose();
                        cmd.CommandText = "select REMAIN_LOAN from LOAN where ID=1";
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            remain_loan = reader.GetString(0).ToString();
                        }
                        reader.Dispose();
                        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error => " + ex.Message);
                    }
                }
            }
        }

        

        
    }
    }

