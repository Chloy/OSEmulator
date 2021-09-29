using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSEmulator.Model {
    class User {
        private int accessLevel;
        public int AccessLevel {
            get;
            set;
        }
        private string login;
        public string Login {
            get;
            set;
        }
        private string pass;
        public string Pass {
            get;
            set;
        }
    }
}
