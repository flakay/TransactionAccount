using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TransactionalCustomerAccount.Models;

namespace TransactionalCustomerAccount.Api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AccountApiController : ApiController
    {
        [Route("AccountApi/GetAccountById")]
        [AcceptVerbs("POST", "PUT")]
        [HttpGet]
        public Account GetAccountById(string Id)
        {
            Account account = new Account();

            if (int.Parse(Id) > 0)
            {
                account.AccountId = 1;
                account.CustomerId = 1;
                account.TransactionId = 1;
                account.Name = "Michael";
                account.Surname = "Orms";
                account.Balance = 10000;
            }

            return account;
        }

        [HttpGet]
        public List<Account> GetAllAccounts()
        {
            Account account1 = new Account();
            Account account2 = new Account();
            Account account3 = new Account();

            account1.AccountId = 1;
            account1.CustomerId = 1;
            account1.TransactionId = 1;
            account1.Name = "Michael";
            account1.Surname = "Orms";
            account1.Balance = 10000;

            account2.AccountId = 2;
            account2.CustomerId = 2;
            account2.TransactionId = 2;
            account2.Name = "James";
            account2.Surname = "Spader";
            account2.Balance = 5000;

            account3.AccountId = 3;
            account3.CustomerId = 3;
            account3.TransactionId = 3;
            account3.Name = "Timothy";
            account3.Surname = "Dalton";
            account3.Balance = 20000;

            List<Account> accounts = new List<Account>
            {
                account1,
                account2,
                account3
            };

            return accounts;
        }
    }
}
