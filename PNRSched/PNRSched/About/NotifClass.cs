using System;
using Xamarin.Forms;

namespace PNRSched
{
    public class NotifClass
    {
        public static class TutubanGPScheds
        {
            public static void Tutuban()
            {
                Tutuban tb1 = new Tutuban();
                string[] Tutuban1 = { tb1.sched1, tb1.sched2, tb1.sched3, tb1.sched4, tb1.sched5 };
                foreach (string Times in Tutuban1)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void Solis()
            {
                Solis sls1 = new Solis();
                string[] Solis1 = { sls1.sched1, sls1.sched2, sls1.sched3, sls1.sched4, sls1.sched5 };
                foreach (string Times in Solis1)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void C3()
            {
                C3 c31 = new C3();
                string[] C31 = { c31.sched1, c31.sched2, c31.sched3, c31.sched4, c31.sched5 };
                foreach (string Times in C31)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void Asistio()
            {
                Asistio ass1 = new Asistio();
                string[] Asistio1 = { ass1.sched1, ass1.sched2, ass1.sched3, ass1.sched4, ass1.sched5 };
                foreach (string Times in Asistio1)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void Sangandaan()
            {
                Sangandaan sd1 = new Sangandaan();
                string[] Sangandaan1 = { sd1.sched1, sd1.sched2, sd1.sched3, sd1.sched4, sd1.sched5 };
                foreach (string Times in Sangandaan1)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void GP()
            {
                GP gp1 = new GP(); //TUTUBAN GP
                string[] GP1 = { gp1.sched1, gp1.sched2, gp1.sched3, gp1.sched4, gp1.sched5 };
                foreach (string Times in GP1)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
        }
        public static class GPTutubanScheds
        {
            public static void Tutuban()
            {
                TUTUBAN3 tb2 = new TUTUBAN3();
                string[] Tutuban2 = { tb2.sched1, tb2.sched2, tb2.sched3, tb2.sched4, tb2.sched5 };
                foreach (string Times in Tutuban2)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void Solis()
            {
                SOLIS3 sls2 = new SOLIS3();
                string[] Solis2 = { sls2.sched1, sls2.sched2, sls2.sched3, sls2.sched4, sls2.sched5 };
                foreach (string Times in Solis2)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void C3()
            {
                C33 c32 = new C33();
                string[] C32 = { c32.sched1, c32.sched2, c32.sched3, c32.sched4, c32.sched5 };
                foreach (string Times in C32)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void Asistio()
            {
                ASISTIO3 ass2 = new ASISTIO3();
                string[] Asistio2 = { ass2.sched1, ass2.sched2, ass2.sched3, ass2.sched4, ass2.sched5 };
                foreach (string Times in Asistio2)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void Sangandaan()
            {
                SDAAN3 sd2 = new SDAAN3();
                string[] Sangandaan2 = { sd2.sched1, sd2.sched2, sd2.sched3, sd2.sched4, sd2.sched5 };
                foreach (string Times in Sangandaan2)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void GP()
            {
                GP3 gp2 = new GP3(); //GP TUTUBAN
                string[] GP2 = { gp2.sched1, gp2.sched2, gp2.sched3, gp2.sched4, gp2.sched5 };
                foreach (string Times in GP2)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
        }
        public static class BicutanGPScheds
        {
            public static void Bicutan1()
            {
                Bicutan1 bic3 = new Bicutan1();
                string[] Bicutan = { bic3.sched1, bic3.sched2, bic3.sched3, bic3.sched4, bic3.sched5, bic3.sched6, bic3.sched7, bic3.sched8 };
                foreach (string Times in Bicutan)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void FTI1()
            {
                FTI1 fti3 = new FTI1();
                string[] FTI = { fti3.sched1, fti3.sched2, fti3.sched3, fti3.sched4, fti3.sched5, fti3.sched6, fti3.sched7, fti3.sched8 };
                foreach (string Times in FTI)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void Nichols1()
            {
                NIC1 nic3 = new NIC1();
                string[] Nichols = { nic3.sched1, nic3.sched2, nic3.sched3, nic3.sched4, nic3.sched5, nic3.sched6, nic3.sched7, nic3.sched8 };
                foreach (string Times in Nichols)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void EDSA1()
            {
                EDSA1 edsa3 = new EDSA1();
                string[] EDSA = { edsa3.sched1, edsa3.sched2, edsa3.sched3, edsa3.sched4, edsa3.sched5, edsa3.sched6, edsa3.sched7, edsa3.sched8 };
                foreach (string Times in EDSA)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void PasayRoad()
            {
                PASAYROAD1 pasay3 = new PASAYROAD1();
                string[] Pasay = { pasay3.sched1, pasay3.sched2, pasay3.sched3, pasay3.sched4, pasay3.sched5, pasay3.sched6, pasay3.sched7, pasay3.sched8 };
                foreach (string Times in Pasay)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void DelaRosa()
            {
                DELAROSA1 delarosa3 = new DELAROSA1();
                string[] DelaRosa = { delarosa3.sched1, delarosa3.sched2, delarosa3.sched3, delarosa3.sched4, delarosa3.sched5, delarosa3.sched6, delarosa3.sched7, delarosa3.sched8 };
                foreach (string Times in DelaRosa)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void VitoCruz()
            {
                VITOCRUZ1 vitocruz3 = new VITOCRUZ1();
                string[] VitoCruz = { vitocruz3.sched1, vitocruz3.sched2, vitocruz3.sched3, vitocruz3.sched4, vitocruz3.sched5, vitocruz3.sched6, vitocruz3.sched7, vitocruz3.sched8 };
                foreach (string Times in VitoCruz)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void SanAndres()
            {
                SANADNRES1 sanandres3 = new SANADNRES1();
                string[] SanAndres = { sanandres3.sched1, sanandres3.sched2, sanandres3.sched3, sanandres3.sched4, sanandres3.sched5, sanandres3.sched6, sanandres3.sched7, sanandres3.sched8 };
                foreach (string Times in SanAndres)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void Paco()
            {
                PACO1 paco3 = new PACO1();
                string[] Paco = { paco3.sched1, paco3.sched2, paco3.sched3, paco3.sched4, paco3.sched5, paco3.sched6, paco3.sched7, paco3.sched8 };
                foreach (string Times in Paco)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void Pandacan()
            {
                PANDACAN1 pandacan3 = new PANDACAN1();
                string[] Pandacan = { pandacan3.sched1, pandacan3.sched2, pandacan3.sched3, pandacan3.sched4, pandacan3.sched5, pandacan3.sched6, pandacan3.sched7, pandacan3.sched8 };
                foreach (string Times in Pandacan)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void StaMesa()
            {
                STAMESA1 stamesa3 = new STAMESA1();
                string[] StaMesa = { stamesa3.sched1, stamesa3.sched2, stamesa3.sched3, stamesa3.sched4, stamesa3.sched5, stamesa3.sched6, stamesa3.sched7, stamesa3.sched8 };
                foreach (string Times in StaMesa)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void Espana()
            {
                ESPANA1 espana3 = new ESPANA1();
                string[] Espana = { espana3.sched1, espana3.sched2, espana3.sched3, espana3.sched4, espana3.sched5, espana3.sched6, espana3.sched7, espana3.sched8 };
                foreach (string Times in Espana)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void LaonLaan()
            {
                LAONLAAN1 laonlaan3 = new LAONLAAN1();
                string[] LaonLaan = { laonlaan3.sched1, laonlaan3.sched2, laonlaan3.sched3, laonlaan3.sched4, laonlaan3.sched5, laonlaan3.sched6, laonlaan3.sched7, laonlaan3.sched8 };
                foreach (string Times in LaonLaan)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void Blumentritt()
            {
                BLUM1 blum3 = new BLUM1();
                string[] Blumentritt = { blum3.sched1, blum3.sched2, blum3.sched3, blum3.sched4, blum3.sched5, blum3.sched6, blum3.sched7, blum3.sched8 };
                foreach (string Times in Blumentritt)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void Solis()
            {
                SOLIS1 solis3 = new SOLIS1();
                string[] Solis = { solis3.sched1, solis3.sched2, solis3.sched3, solis3.sched4, solis3.sched5, solis3.sched6, solis3.sched7, solis3.sched8 };
                foreach (string Times in Solis)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void C3()
            {
                C31 c33 = new C31();
                string[] C3 = { c33.sched1, c33.sched2, c33.sched3, c33.sched4, c33.sched5, c33.sched6, c33.sched7, c33.sched8 };
                foreach (string Times in C3)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void Asistio()
            {
                ASISTIO1 ass3 = new ASISTIO1();
                string[] Asistio = { ass3.sched1, ass3.sched2, ass3.sched3, ass3.sched4, ass3.sched5, ass3.sched6, ass3.sched7, ass3.sched8 };
                foreach (string Times in Asistio)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void Sangandaan()
            {
                SDAAN1 sdaan3 = new SDAAN1();
                string[] Sangandaan = { sdaan3.sched1, sdaan3.sched2, sdaan3.sched3, sdaan3.sched4, sdaan3.sched5, sdaan3.sched6, sdaan3.sched7, sdaan3.sched8 };
                foreach (string Times in Sangandaan)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void GovernorPascual()
            {
                GP1 gp3 = new GP1(); //BIC GP
                string[] GP = { gp3.sched1, gp3.sched2, gp3.sched3, gp3.sched4, gp3.sched5, gp3.sched6, gp3.sched7, gp3.sched8 };
                foreach (string Times in GP)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
        }
        public static class GPBicutanScheds
        {
            public static void Bicutan1()
            {
                BICUTAN2 bic3 = new BICUTAN2();
                string[] Bicutan = { bic3.sched1, bic3.sched2, bic3.sched3, bic3.sched4, bic3.sched5, bic3.sched6, bic3.sched7, bic3.sched8 };
                foreach (string Times in Bicutan)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void FTI1()
            {
                FTI2 fti3 = new FTI2();
                string[] FTI = { fti3.sched1, fti3.sched2, fti3.sched3, fti3.sched4, fti3.sched5, fti3.sched6, fti3.sched7, fti3.sched8 };
                foreach (string Times in FTI)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void Nichols1()
            {
                NICHOLS2 nic3 = new NICHOLS2();
                string[] Nichols = { nic3.sched1, nic3.sched2, nic3.sched3, nic3.sched4, nic3.sched5, nic3.sched6, nic3.sched7, nic3.sched8 };
                foreach (string Times in Nichols)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void EDSA2()
            {
                EDSA2 edsa3 = new EDSA2();
                string[] EDSA = { edsa3.sched1, edsa3.sched2, edsa3.sched3, edsa3.sched4, edsa3.sched5, edsa3.sched6, edsa3.sched7, edsa3.sched8 };
                foreach (string Times in EDSA)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void PasayRoad()
            {
                PASAYROAD2 pasay3 = new PASAYROAD2();
                string[] Pasay = { pasay3.sched1, pasay3.sched2, pasay3.sched3, pasay3.sched4, pasay3.sched5, pasay3.sched6, pasay3.sched7, pasay3.sched8 };
                foreach (string Times in Pasay)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void DelaRosa()
            {
                DELAROSA2 delarosa3 = new DELAROSA2();
                string[] DelaRosa = { delarosa3.sched1, delarosa3.sched2, delarosa3.sched3, delarosa3.sched4, delarosa3.sched5, delarosa3.sched6, delarosa3.sched7, delarosa3.sched8 };
                foreach (string Times in DelaRosa)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void VitoCruz()
            {
                VITOCRUZ2 vitocruz3 = new VITOCRUZ2();
                string[] VitoCruz = { vitocruz3.sched1, vitocruz3.sched2, vitocruz3.sched3, vitocruz3.sched4, vitocruz3.sched5, vitocruz3.sched6, vitocruz3.sched7, vitocruz3.sched8 };
                foreach (string Times in VitoCruz)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void SanAndres()
            {
                SANANDRES2 sanandres3 = new SANANDRES2();
                string[] SanAndres = { sanandres3.sched1, sanandres3.sched2, sanandres3.sched3, sanandres3.sched4, sanandres3.sched5, sanandres3.sched6, sanandres3.sched7, sanandres3.sched8 };
                foreach (string Times in SanAndres)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void Paco()
            {
                PACO2 paco3 = new PACO2();
                string[] Paco = { paco3.sched1, paco3.sched2, paco3.sched3, paco3.sched4, paco3.sched5, paco3.sched6, paco3.sched7, paco3.sched8 };
                foreach (string Times in Paco)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void Pandacan()
            {
                PANDACAN2 pandacan3 = new PANDACAN2();
                string[] Pandacan = { pandacan3.sched1, pandacan3.sched2, pandacan3.sched3, pandacan3.sched4, pandacan3.sched5, pandacan3.sched6, pandacan3.sched7, pandacan3.sched8 };
                foreach (string Times in Pandacan)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void StaMesa()
            {
                STAMESA2 stamesa3 = new STAMESA2();
                string[] StaMesa = { stamesa3.sched1, stamesa3.sched2, stamesa3.sched3, stamesa3.sched4, stamesa3.sched5, stamesa3.sched6, stamesa3.sched7, stamesa3.sched8 };
                foreach (string Times in StaMesa)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void Espana()
            {
                ESPANA2 espana3 = new ESPANA2();
                string[] Espana = { espana3.sched1, espana3.sched2, espana3.sched3, espana3.sched4, espana3.sched5, espana3.sched6, espana3.sched7, espana3.sched8 };
                foreach (string Times in Espana)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void LaonLaan()
            {
                LAONLAAN2 laonlaan3 = new LAONLAAN2();
                string[] LaonLaan = { laonlaan3.sched1, laonlaan3.sched2, laonlaan3.sched3, laonlaan3.sched4, laonlaan3.sched5, laonlaan3.sched6, laonlaan3.sched7, laonlaan3.sched8 };
                foreach (string Times in LaonLaan)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void Blumentritt()
            {
                BLUM2 blum3 = new BLUM2();
                string[] Blumentritt = { blum3.sched1, blum3.sched2, blum3.sched3, blum3.sched4, blum3.sched5, blum3.sched6, blum3.sched7, blum3.sched8 };
                foreach (string Times in Blumentritt)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void Solis()
            {
                SOLIS2 solis3 = new SOLIS2();
                string[] Solis = { solis3.sched1, solis3.sched2, solis3.sched3, solis3.sched4, solis3.sched5, solis3.sched6, solis3.sched7, solis3.sched8 };
                foreach (string Times in Solis)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void C3()
            {
                C32 c33 = new C32();
                string[] C3 = { c33.sched1, c33.sched2, c33.sched3, c33.sched4, c33.sched5, c33.sched6, c33.sched7, c33.sched8 };
                foreach (string Times in C3)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void Asistio()
            {
                ASSITIO2 ass3 = new ASSITIO2();
                string[] Asistio = { ass3.sched1, ass3.sched2, ass3.sched3, ass3.sched4, ass3.sched5, ass3.sched6, ass3.sched7, ass3.sched8 };
                foreach (string Times in Asistio)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void Sangandaan()
            {
                SDAAN2 sdaan3 = new SDAAN2();
                string[] Sangandaan = { sdaan3.sched1, sdaan3.sched2, sdaan3.sched3, sdaan3.sched4, sdaan3.sched5, sdaan3.sched6, sdaan3.sched7, sdaan3.sched8 };
                foreach (string Times in Sangandaan)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
            public static void GovernorPascual()
            {
                GP2 gp3 = new GP2(); //BIC GP
                string[] GP = { gp3.sched1, gp3.sched2, gp3.sched3, gp3.sched4, gp3.sched5, gp3.sched6, gp3.sched7, gp3.sched8 };
                foreach (string Times in GP)
                {
                    DateTime trigger = DateTime.Parse(Times);
                    DependencyService.Get<ILocalNotif>().Alarm(trigger.Millisecond);
                }
            }
        }
    }
}