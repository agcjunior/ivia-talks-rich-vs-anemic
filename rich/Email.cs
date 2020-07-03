using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace rich
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            if (!EmailValido(address))
                AddNotification("Email", "Email inválido");

            Address = address;
        }

        public string Address { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Address;
        }

        private bool EmailValido(string email)
        {
            var regex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }
    }
    }
