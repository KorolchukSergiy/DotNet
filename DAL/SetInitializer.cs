using System.Collections.Generic;
using System.Data.Entity;

namespace DAL
{
    internal class SetInitializer<T> : DropCreateDatabaseAlways<Shop>
    {
        protected override void Seed(Shop context)
        {
            Producer Intel = new Producer
            {
                Name = "Intel"                          
            };
            Producer AMD = new Producer
            {
                Name = "Intel"
            };
            Producer MSI = new Producer
            {
                Name = "Intel"
            };
            CPU I7700 = new CPU
            {

            };
            context.Producers.AddRange(new List<Producer> { Intel, AMD, MSI });
            Provider KTC = new Provider
            {
                 Name="KTC"
            };
            Provider Enter = new Provider
            {
                Name = "Enter"
            };
            Provider I5 = new Provider
            {
                Name = "I5"
            };

            context.Providers.AddRange(new List<Provider> { KTC, Enter, I5 });
            base.Seed(context);
        }
    }
}