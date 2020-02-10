using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public static class IEnumerableVsIQueryable
    {
        public static void test()
        {
            List<Card> listC = new List<Card>();

            listC.Add(new Card { Id = "1", CardHolderFirstName = "FirstName1", CardHolderLastName = "LastName1", CardNumber = "1111" });
            listC.Add(new Card { Id = "2", CardHolderFirstName = "FirstName2", CardHolderLastName = "LastName2", CardNumber = "2222" });
            listC.Add(new Card { Id = "3", CardHolderFirstName = "FirstName3", CardHolderLastName = "LastName3", CardNumber = "3333" });
            listC.Add(new Card { Id = "4", CardHolderFirstName = "FirstName4", CardHolderLastName = "LastName4", CardNumber = "4444" });
            listC.Add(new Card { Id = "5", CardHolderFirstName = "FirstName5", CardHolderLastName = "LastName5", CardNumber = "5555" });
            listC.Add(new Card { Id = "6", CardHolderFirstName = "FirstName6", CardHolderLastName = "LastName6", CardNumber = "6666" });


            IEnumerable<Card> IE = listC.AsEnumerable().Where(d => d.Id.Equals("1"));
            IE = IE.Take<Card>(3);

            IQueryable<Card> IQ = listC.AsQueryable().Where(d => d.Id.Equals("1"));
            IQ = IQ.Take<Card>(3);







        }
    }
}
