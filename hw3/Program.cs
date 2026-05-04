using System.Security.Cryptography.X509Certificates;

namespace assingment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region - account
            Account acc = new Account(1, 1000);
            VipAccount vipAcc = new VipAccount(2, 2000);

            acc.Withdraw(5000);
            Console.WriteLine();
            vipAcc.Withdraw(7000);

            Console.WriteLine();
            #endregion

            #region - aircraft
            Aircraft[] planes = new Aircraft[4];
            planes[0] = new PassengerPlane("12",10,50);
            planes[1] = new PassengerPlane("13", 20, 100);
            planes[2] = new FighterJet("14", 30, true);
            planes[3] = new FighterJet("15", 40, true);

            for (int i = 0; i < planes.Length; i++)
            {
                planes[i].PrintStatus();
                if (planes[i] is FighterJet)
                {
                    ((FighterJet)planes[i]).FireMissile();
                    Console.WriteLine();
                }
            }
            #endregion
        }
    }
}
