using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public static class ModelsFactory
    {
        private static Airport.Models.AbstractModel singleton = null;
        private static string model = "Sql";

        public static Airport.Models.AbstractModel Model
        {
            get
            {
                if (singleton == null)
                {
                    switch (model)
                    {
                        case "Sql":
                            singleton = new Models.ModelSql();
                            break;
                        case "Natif":
                            singleton = new Models.ModelNatif();
                            break;
                        default:
                            singleton = new Models.ModelNatif();
                            break;
                    }

                }
                return singleton;
            }
        }
    }
}
