using System;
using System.Collections.Generic;
using System.Text;

namespace lab3_mpp.domain
{
    class Voluntar : Entity<long>
    {
        public long IDVoluntar { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }

        public Voluntar(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

    }
}
