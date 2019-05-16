using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore
{
    class Logger
    {




        public void ActionCategory(int value)
        {
            try
            {
                switch (value)
                {
                    case 1:
                        log_action_del?.Invoke("The user have entered");
                        break;
                    case 2:
                        log_action_del?.Invoke("The user have exit");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
