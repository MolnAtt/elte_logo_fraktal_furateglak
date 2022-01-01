using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		/* Függvények */


		/* Függvények vége */
		void FELADAT()
		{
			/* Ezt indítja a START gomb! */

			Fraktál(4, 200);

		}

		void Fraktál(int szint, double méret)
		{
            for (int i = szint; i > 0; i--)
            {
				Lopakszik(méret);
				Jobbra(90);
				Lopakszik(2*méret);
				Jobbra(90);
				Tégla(méret / 3, Avatar.erős_színek_fehérre[i]);
				Lopakszik(2 * méret);
				Tégla(méret / 3, Avatar.erős_színek_fehérre[i]);
				Jobbra(90);
				Lopakszik(4 * méret);
				Jobbra(90);
				Tégla(méret / 3, Avatar.erős_színek_fehérre[i]);
				Lopakszik(2 * méret);
				Tégla(méret / 3, Avatar.erős_színek_fehérre[i]);
				Jobbra(90);
				Lopakszik(2 * méret);
				Jobbra(90);
				Lopakszik(méret);
				Jobbra(180);

				méret /= 2;
			}
		}
		void Tégla(double méret, Color szín)
        {
			Lopakszik(méret);
            for (int i = 0; i < 3; i++)/*-ism-*/ { Jobbra(90); Előre(méret); }
			for (int i = 0; i < 3; i++)/*-ism-*/ { Előre(méret); Jobbra(90); }
			Lopakszik(méret);
			Jobbra(180);
			Tölt(szín);
        }

		void Lopakszik(double méret) { Tollat(fel); Előre(méret / 2); Tollat(le); }
    }
}
