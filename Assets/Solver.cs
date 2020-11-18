using UnityEngine;

public class Solver : MonoBehaviour
{
    public MainScript refScr;
    public string SolveStatus;
    private string _1;
	private string _2;
	private string _3;
	private string _4;
	private string _5;
	private string _6;
	private string _7;
	private string _8;
	private string _9;
	private string _10;
	private string _11;
	private string _12;
	private string _13;
	private string _14;
	private string _15;
	private string _16;
	private string _17;

    public int MoveAgs()
    {
        _1 = _2;
		_2 = _3;
		_3 = _4;
		_4 = _5;
		_5 = _6;
		_6 = _7;
		_7 = _8;
		_8 = _9;
		_9 = _10;
		_10 = _11;
		_11 = _12;
		_12 = _13;
		_13 = _14;
		_14 = _15;
		_15 = _16;
		_16 = _17;
		_17 = null;
		if (_1 == "R")
		{
			refScr.whatDoUWannaDo = "RToMoveAgs";
		}
		else if (_1 == "R_")
		{
			refScr.whatDoUWannaDo = "R_ToMoveAgs";
		}
		else if (_1 == "F")
		{
			refScr.whatDoUWannaDo = "FToMoveAgs";
		}
		else if (_1 == "F_")
		{
			refScr.whatDoUWannaDo = "F_ToMoveAgs";
		}
		else if (_1 == "U")
		{
			refScr.whatDoUWannaDo = "UToMoveAgs";
		}
		else if (_1 == "U_")
		{
			refScr.whatDoUWannaDo = "U_ToMoveAgs";
		}
		else if (_1 == "L")
		{
			refScr.whatDoUWannaDo = "LToMoveAgs";
		}
		else if (_1 == "L_")
		{
			refScr.whatDoUWannaDo = "L_ToMoveAgs";
		}
		else if (_1 == "B")
		{
			refScr.whatDoUWannaDo = "BToMoveAgs";
		}
		else if (_1 == "B_")
		{
			refScr.whatDoUWannaDo = "B_ToMoveAgs";
		}
		else if (_1 == "D")
		{
			refScr.whatDoUWannaDo = "DToMoveAgs";
		}
		else if (_1 == "D_")
		{
			refScr.whatDoUWannaDo = "D_ToMoveAgs";
		}
		else if (_1 == null)
		{
			SolveFirstMargini();
		}
		return 0;
    }


    public void SolveFirstMargini()
	{
		if (refScr.UMove[1] == 'w' && refScr.UMove[3] == 'w' && refScr.UMove[5] == 'w' && refScr.UMove[7] == 'w' && refScr.FMove[1]=='r' && refScr.RMove[1]=='o' && refScr.BMove[7]=='g' && refScr.LMove[1]=='b')
		{
			SolveStatus = "SolveFirstColturi";
			SolveFirstColturi();
		}



		//r-w
		else if (refScr.UMove[7] == 'r' && refScr.FMove[1] == 'w')
		{
			_1 = "F_";_2 = "L";_3 = "D";_4 = "L_";_5 = "F";_6="F";
			refScr.F_("MoveAgs");
		}
		else if (refScr.UMove[5] == 'w' && refScr.RMove[1] == 'r')
		{
			_1 = "R";_2 = "R";_3 = "D_";_4 = "F";_5 = "F";
			refScr.R("MoveAgs");
		}
		else if (refScr.UMove[5] == 'r' && refScr.RMove[1] == 'w')
		{
			_1 = "R_";_2 = "F_";
			refScr.R_("MoveAgs");
		}
		else if (refScr.UMove[1] == 'w' && refScr.BMove[7] == 'r')
		{
			_1 = "B";
			_2 = "B";
			_3 = "D";
			_4 = "D";
			_5 = "F";
			_6 = "F";
			refScr.B("MoveAgs");
		}
		else if (refScr.UMove[1] == 'r' && refScr.BMove[7] == 'w')
		{
			_1 = "B";
			_2 = "B";
			_3 = "D_";
			_4 = "R";
			_5 = "F_";
			_6 = "R_";
			refScr.B("MoveAgs");
		}
		else if (refScr.UMove[3] == 'w' && refScr.LMove[1] == 'r')
		{
			_1 = "L";
			_2 = "L";
			_3 = "D";
			_4 = "F";
			_5 = "F";
			refScr.L("MoveAgs");
		}
		else if (refScr.UMove[3] == 'r' && refScr.LMove[1] == 'w')
		{
			_1 = "L";
			_2 = "F";
			refScr.L("MoveAgs");
		}


		else if (refScr.FMove[5] == 'r' && refScr.RMove[3] == 'w')
		{
			_1 = "F_";
			refScr.F_("MoveAgs");
		}
		else if (refScr.FMove[5] == 'w' && refScr.RMove[3] == 'r')
		{
			_1="R_";_2="D_";_3="R";_4="F";_5="F";
			refScr.R_("MoveAgs");
		}
		else if (refScr.RMove[5] == 'w' && refScr.BMove[5] == 'r')//asta
		{
			_1 = "R";
			_2 = "R";
			_3 = "F_";
			_4 = "R";
			_5 = "R";
			refScr.R("MoveAgs");
		}
		else if (refScr.RMove[5] == 'r' && refScr.BMove[5] == 'w')//verificat pana aici
		{
			_1 = "R";_2 = "D_";_3 = "R_";_4 = "F";_5="F";
			refScr.R("MoveAgs");
		}
		else if (refScr.FMove[3] == 'r' && refScr.LMove[5] == 'w')
		{
			_1 = "F";
			refScr.F("MoveAgs");
		}
		else if (refScr.FMove[3] == 'w' && refScr.LMove[5] == 'r')
		{
			_1 = "L";
			_2 = "D";
			_3 = "F";
			_4 = "F";
			refScr.L("MoveAgs");
		}
		else if (refScr.LMove[3] == 'r' && refScr.BMove[3] == 'w')
		{
			_1 = "L_";
			_2 = "D";
			_3 = "F";
			_4 = "F";
			refScr.L_("MoveAgs");
		}
		else if (refScr.LMove[3] == 'w' && refScr.BMove[3] == 'r')
		{
			_1 = "L";
			_2 = "L";
			_3 = "F";
			refScr.L("MoveAgs");
		}


		else if (refScr.FMove[7]=='r' && refScr.DMove[1]=='w')
		{
			_1="F";_2="F";
			refScr.F("MoveAgs");
		}
		else if (refScr.FMove[7]=='w' && refScr.DMove[1]=='r')//tested
		{
			_1="F_";_2="R_";_3="D_";_4="F";_5="R";_6="F";
			refScr.F_("MoveAgs");
		}
		else if (refScr.RMove[7]=='r' && refScr.DMove[5]=='w')
		{
			_1="D_";_2="F";_3="F";
			refScr.D_("MoveAgs");
		}
		else if (refScr.RMove[7]=='w' && refScr.DMove[5]=='r')
		{
			_1="R";_2="F_";
			refScr.R_("MoveAgs");
		}
		else if (refScr.LMove[7]=='w' && refScr.DMove[3]=='r')
		{
			_1="L_";_2="F";
			refScr.L_("MoveAgs");
		}
		else if (refScr.LMove[7]=='r' && refScr.DMove[3]=='w')
		{
			_1="D";_2="F";_3="F";
			refScr.D("MoveAgs");
		}
		else if (refScr.BMove[1]=='r' && refScr.DMove[7]=='w')
		{
			_1="D";_2="D";_3="F";_4="F";
			refScr.D("MoveAgs");
		}
		else if (refScr.BMove[1]=='w' && refScr.DMove[7]=='r')
		{
			_1="D_";_2="R";_3="F_";_4="R_";
			refScr.D_("MoveAgs");
		}




		//o-w
		else if (refScr.UMove[5]=='o' && refScr.RMove[1]=='w')
		{
			_1="R_";_2="F";_3="D";_4="F_";_5="R";_6="R";
			refScr.R_("MoveAgs");
		}
		else if (refScr.UMove[1]=='w' && refScr.BMove[7]=='o')
		{
			_1="B";_2="B";_3="D_";_4="R";_5="R";
			refScr.R("MoveAgs");
		}
		else if (refScr.UMove[1]=='o' && refScr.BMove[7]=='w')//tested
		{
			_1="B_";_2="R_";
			refScr.B_("MoveAgs");
		}
		else if (refScr.UMove[3]=='w' && refScr.LMove[1]=='o')
		{
			_1="L";_2="L";_3="D";_4="D";_5="R";_6="R";
			refScr.L("MoveAgs");
		}
		else if (refScr.UMove[3]=='o' && refScr.LMove[1]=='w')
		{
			_1="L";_2="L";_3="D";_4="F_";_5="R";_6="F";
			refScr.L("MoveAgs");
		}
		else if (refScr.UMove[7]=='w' && refScr.FMove[1]=='o')
		{
			_1="F";_2="F";_3="D";_4="R";_5="R";
			refScr.F("MoveAgs");
		}
		else if (refScr.UMove[7]=='o' && refScr.FMove[1]=='w')
		{
			_1="F";_2="R";
			refScr.F("MoveAgs");
		}


		else if (refScr.FMove[5]=='w' && refScr.RMove[3]=='o')
		{
			_1="R";
			refScr.R("MoveAgs");
		}
		else if (refScr.FMove[5]=='o' && refScr.RMove[3]=='w')
		{
			_1="R_";_2="D_";_3="F_";_4="R";_5="F";
			refScr.R_("MoveAgs");
		}
		else if (refScr.FMove[3]=='w' && refScr.LMove[5]=='o')
		{
			_1="F";_2="F";_3="R";_4="F_";_5="F";
			refScr.F("MoveAgs");
		}
		else if (refScr.FMove[3]=='o' && refScr.LMove[5]=='w')
		{
			_1="F_";_2="D";_3="F";_4="R";_5="R";
			refScr.F_("MoveAgs");
		}
		else if (refScr.RMove[5]=='o' && refScr.BMove[5]=='w')
		{
			_1="R_";_2="D_";_3="R";_4="F";_5="F";
			refScr.R_("MoveAgs");
		}
		else if (refScr.RMove[5]=='w' && refScr.BMove[5]=='o')
		{
			_1="R";_2="R";_3="F_";_4="R_";_5="R_";
			refScr.R("MoveAgs");
		}
		else if (refScr.LMove[3]=='w' && refScr.BMove[3]=='o')
		{
			_1="L_";_2="D";_3="L";_4="F_";_5="R";_6="F";
			refScr.L_("MoveAgs");
		}
		else if (refScr.LMove[3]=='o' && refScr.BMove[3]=='w')
		{
			_1="L_";_2="D";_3="L";_4="D";_5="R";_6="R";
			refScr.L_("MoveAgs");
		}


		else if (refScr.FMove[7]=='o' && refScr.DMove[1]=='w')
		{
			_1="D";_2="R";_3="R";
			refScr.D("MoveAgs");
		}
		else if (refScr.FMove[7]=='w' && refScr.DMove[1]=='o')
		{
			_1="F_";_2="R";_3="F";
			refScr.F_("MoveAgs");
		}
		else if (refScr.RMove[7]=='o' && refScr.DMove[5]=='w')
		{
			_1="R";_2="R";
			refScr.R("MoveAgs");
		}
		else if (refScr.RMove[7]=='w' && refScr.DMove[5]=='o')
		{
			_1="R";_2="F";_3="D";_4="F_";_5="R";_6="R";
			refScr.R("MoveAgs");
		}
		else if (refScr.BMove[1]=='w' && refScr.DMove[7]=='o')//asta
		{
			_1="B";_2="R_";_3="B_";
			refScr.R("MoveAgs");
		}
		else if (refScr.BMove[1]=='o' && refScr.DMove[7]=='w')
		{
			_1="D_";_2="F";_3="F";
			refScr.D_("MoveAgs");
		}
		else if (refScr.LMove[7]=='o' && refScr.DMove[3]=='w')
		{
			_1="D";_2="D";_3="R";_4="R";
			refScr.D("MoveAgs");
		}
		else if (refScr.LMove[7]=='w' && refScr.DMove[3]=='o')
		{
			_1="D";_2="F_";_3="R";_4="F";
			refScr.D("MoveAgs");
		}




		//g-w
		else if (refScr.UMove[1]=='g' && refScr.BMove[7]=='w')
		{
			_1="B_";_2="R";_3="D";_4="R_";_5="B";_6="B";
			refScr.B_("MoveAgs");
		}
		else if (refScr.RMove[1]=='w' && refScr.UMove[5]=='g')
		{
			_1="R";_2="B";
			refScr.R("MoveAgs");
		}
		else if (refScr.RMove[1]=='g' && refScr.UMove[5]=='w')
		{
			_1="R";_2="R";_3="D";_4="B";_5="B";
			refScr.R("MoveAgs");
		}
		else if (refScr.UMove[7]=='w' && refScr.FMove[1]=='g')
		{
			_1="F";_2="F";_3="D";_4="D";_5="B";_6="B";
			refScr.F("MoveAgs");
		}
		else if (refScr.UMove[7]=='g' && refScr.FMove[1]=='w')
		{
			_1="F";_2="F";_3="D";_4="R_";_5="B";_6="R";
			refScr.F("MoveAgs");
		}
		else if (refScr.UMove[3]=='g' && refScr.LMove[1]=='w')
		{
			_1="L_";_2="B_";
			refScr.L_("MoveAgs");
		}
		else if (refScr.UMove[3]=='w' && refScr.LMove[1]=='g')
		{
			_1="L";_2="L";_3="D_";_4="B";_5="B";
			refScr.L("MoveAgs");
		}


		else if (refScr.RMove[5]=='w' && refScr.BMove[5]=='g')
		{
			_1="B";
			refScr.B("MoveAgs");
		}
		else if (refScr.RMove[5]=='g' && refScr.BMove[5]=='w')
		{
			_1="R";_2="D";_3="B";_4="B";
			refScr.R("MoveAgs");
		}
		else if (refScr.BMove[3]=='g' && refScr.LMove[3]=='w')
		{
			_1="B_";
			refScr.B_("MoveAgs");
		}
		else if (refScr.BMove[3]=='w' && refScr.LMove[3]=='g')
		{
			_1="L_";_2="D_";_3="B";_4="B";
			refScr.L_("MoveAgs");
		}
		else if (refScr.LMove[5]=='w' && refScr.FMove[3]=='g')
		{
			_1="L";_2="L";_3="B_";_4="L";_5="L";
			refScr.L("MoveAgs");
		}
		else if (refScr.LMove[5]=='g' && refScr.FMove[3]=='w')
		{
			_1="L";_2="D_";_3="L_";_4="B";_5="B";
			refScr.L("MoveAgs");
		}
		else if (refScr.RMove[3]=='w' && refScr.FMove[5]=='g')
		{
			_1="R";_2="R";_3="B";_4="R";_5="R";
			refScr.R("MoveAgs");
		}
		else if (refScr.RMove[3]=='g' && refScr.FMove[5]=='w')
		{
			_1="R_";_2="D";_3="R";_4="B";_5="B";
			refScr.R("MoveAgs");
		}


		else if (refScr.BMove[1]=='g' && refScr.DMove[7]=='w')
		{
			_1="B";_2="B";
			refScr.B("MoveAgs");
		}
		else if (refScr.BMove[1]=='w' && refScr.DMove[7]=='g')
		{
			_1="B";_2="R";_3="D";_4="R_";_5="B";_6="B";
			refScr.B("MoveAgs");
		}
		else if (refScr.LMove[7]=='g' && refScr.DMove[3]=='w')
		{
			_1="D_";_2="B";_3="B";
			refScr.D_("MoveAgs");
		}
		else if (refScr.LMove[7]=='w' && refScr.DMove[3]=='g')
		{
			_1="L";_2="B_";_3="L_";
			refScr.L("MoveAgs");
		}
		else if (refScr.FMove[7]=='g' && refScr.DMove[1]=='w')
		{
			_1="D";_2="D";_3="B";_4="B";
			refScr.D("MoveAgs");
		}
		else if (refScr.FMove[7]=='w' && refScr.DMove[1]=='g')
		{
			_1="D_";_2="L";_3="B_";_4="L_";
			refScr.D_("MoveAgs");
		}
		else if (refScr.RMove[7]=='g' && refScr.DMove[5]=='w')
		{
			_1="D";_2="B";_3="B";
			refScr.D("MoveAgs");
		}
		else if (refScr.RMove[7]=='w' && refScr.DMove[5]=='g')
		{
			_1="R_";_2="B";_3="R";
			refScr.R_("MoveAgs");
		}
		



		//b-w
		else if (refScr.LMove[1]=='w' && refScr.UMove[3]=='b')
		{
			_1="L";_2="L";_3="D";_4="F";_5="L_";_6="F_";
			refScr.L("MoveAgs");
		}
		else if (refScr.BMove[7]=='w' && refScr.UMove[1]=='b')
		{
			_1="B";_2="L";
			refScr.B("MoveAgs");
		}
		else if (refScr.BMove[7]=='b' && refScr.UMove[1]=='w')
		{
			_1="B";_2="B";_3="D";_4="L";_5="L";
			refScr.B("MoveAgs");
		}
		else if (refScr.UMove[5]=='w' && refScr.RMove[1]=='b')
		{
			_1="R";_2="R";_3="D";_4="D";_5="L";_6="L";
			refScr.R("MoveAgs");
		}
		else if (refScr.UMove[5]=='b' && refScr.RMove[1]=='w')
		{
			_1="R";_2="R";_3="D_";_4="F";_5="L_";_6="F_";
			refScr.R("MoveAgs");
		}
		else if (refScr.UMove[7]=='b' && refScr.FMove[1]=='w')
		{
			_1="F_";_2="L_";
			refScr.F_("MoveAgs");
		}
		else if (refScr.UMove[7]=='w' && refScr.FMove[1]=='b')
		{
			_1="F";_2="F";_3="D_";_4="L";_5="L";
			refScr.F("MoveAgs");
		}


		else if (refScr.LMove[5]=='b' && refScr.FMove[3]=='w')
		{
			_1="L_";
			refScr.L_("MoveAgs");
		}
		else if (refScr.LMove[5]=='w' && refScr.FMove[3]=='b')
		{
			_1="F_";_2="D_";_3="F";_4="L";_5="L";
			refScr.F_("MoveAgs");
		}
		else if (refScr.LMove[3]=='b' && refScr.BMove[3]=='w')
		{
			_1="L";
			refScr.L("MoveAgs");
		}
		else if (refScr.LMove[3]=='w' && refScr.BMove[3]=='b')
		{
			_1="B";_2="D";_3="B_";_4="L";_5="L";
			refScr.B("MoveAgs");
		}
		else if (refScr.FMove[5]=='b' && refScr.RMove[3]=='w')
		{
			_1="F";_2="D_";_3="F_";_4="L";_5="L";
			refScr.F("MoveAgs");
		}
		else if (refScr.FMove[5]=='w' && refScr.RMove[3]=='b')
		{
			_1="F";_2="F";_3="L_";_4="F";_5="F";
			refScr.F("MoveAgs");
		}
		else if (refScr.BMove[5]=='w' && refScr.RMove[5]=='b')
		{
			_1="B";_2="B";_3="L";_4="B";_5="B";
			refScr.B("MoveAgs");
		}
		else if (refScr.BMove[5]=='b' && refScr.RMove[5]=='w')
		{
			_1="B_";_2="D";_3="B";_4="L";_5="L";
			refScr.B_("MoveAgs");
		}
		

		else if (refScr.LMove[7]=='b' && refScr.DMove[3]=='w')
		{
			_1="L";_2="L";
			refScr.L("MoveAgs");
		}
		else if (refScr.LMove[7]=='w' && refScr.DMove[3]=='b')
		{
			_1="D";_2="F";_3="L_";_4="F_";
			refScr.D("MoveAgs");
		}
		else if (refScr.FMove[7]=='w' && refScr.DMove[1]=='b')
		{
			_1="F";_2="L_";_3="F_";
			refScr.F("MoveAgs");
		}
		else if (refScr.FMove[7]=='b' && refScr.DMove[1]=='w')
		{
			_1="D_";_2="L";_3="L";
			refScr.D_("MoveAgs");
		}
		else if (refScr.BMove[1]=='b' && refScr.DMove[7]=='w')
		{
			_1="D";_2="L";_3="L";
			refScr.D("MoveAgs");
		}
		else if (refScr.BMove[1]=='w' && refScr.DMove[7]=='b')
		{
			_1="B_";_2="L";_3="B";
			refScr.B_("MoveAgs");
		}
		else if (refScr.RMove[7]=='w' && refScr.DMove[5]=='b')
		{
			_1="D";_2="B_";_3="L";_4="B";
			refScr.D("MoveAgs");
		}
		else if (refScr.RMove[7]=='b' && refScr.DMove[5]=='w')
		{
			_1="D";_2="D";_3="L";_4="L";
			refScr.D("MoveAgs");
		}
    }

    public void SolveFirstColturi()
	{
	}

	private void SolveSecond()
	{
		SolveStatus = "Third";
	}
}
