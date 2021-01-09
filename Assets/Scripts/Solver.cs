using UnityEngine;

public class Solver : MonoBehaviour
{
    public MainScript r;
    string SolveStatus = "SolveFirstMargini";
    public string _1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17;

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
			r.whatDoUWannaDo = "RToMoveAgs";
		}
		else if (_1 == "R_")
		{
			r.whatDoUWannaDo = "R_ToMoveAgs";
		}
		else if (_1 == "F")
		{
			r.whatDoUWannaDo = "FToMoveAgs";
		}
		else if (_1 == "F_")
		{
			r.whatDoUWannaDo = "F_ToMoveAgs";
		}
		else if (_1 == "U")
		{
			r.whatDoUWannaDo = "UToMoveAgs";
		}
		else if (_1 == "U_")
		{
			r.whatDoUWannaDo = "U_ToMoveAgs";
		}
		else if (_1 == "L")
		{
			r.whatDoUWannaDo = "LToMoveAgs";
		}
		else if (_1 == "L_")
		{
			r.whatDoUWannaDo = "L_ToMoveAgs";
		}
		else if (_1 == "B")
		{
			r.whatDoUWannaDo = "BToMoveAgs";
		}
		else if (_1 == "B_")
		{
			r.whatDoUWannaDo = "B_ToMoveAgs";
		}
		else if (_1 == "D")
		{
			r.whatDoUWannaDo = "DToMoveAgs";
		}
		else if (_1 == "D_")
		{
			r.whatDoUWannaDo = "D_ToMoveAgs";
		}
		else if (_1 == null)
		{
			switch (SolveStatus)
			{
				case "SolveFirstMargini":
					SolveFirstMargini();
					break;
				case "SolveFirstColturi":
					SolveFirstColturi();
					break;
				case "SolveSecond":
					SolveSecond();
					break;
			}
		}
		return 0;
    }


    public void SolveFirstMargini()
	{
		if (r.UMove[1] == 'w' && r.UMove[3] == 'w' && r.UMove[5] == 'w' && r.UMove[7] == 'w' && r.FMove[1]=='r' && r.RMove[1]=='o' && r.BMove[7]=='g' && r.LMove[1]=='b')
		{
			SolveStatus = "SolveFirstColturi";
			SolveFirstColturi();
		}


		//r-w
		else if (r.UMove[7] == 'r' && r.FMove[1] == 'w')
		{
			_1 = "F_";_2 = "L";_3 = "D";_4 = "L_";_5 = "F";_6="F";
			r.F_("MoveAgs");
		}
		else if (r.UMove[5] == 'w' && r.RMove[1] == 'r')
		{
			_1 = "R";_2 = "R";_3 = "D_";_4 = "F";_5 = "F";
			r.R("MoveAgs");
		}
		else if (r.UMove[5] == 'r' && r.RMove[1] == 'w')
		{
			_1 = "R_";_2 = "F_";
			r.R_("MoveAgs");
		}
		else if (r.UMove[1] == 'w' && r.BMove[7] == 'r')
		{
			_1 = "B";
			_2 = "B";
			_3 = "D";
			_4 = "D";
			_5 = "F";
			_6 = "F";
			r.B("MoveAgs");
		}
		else if (r.UMove[1] == 'r' && r.BMove[7] == 'w')
		{
			_1 = "B";
			_2 = "B";
			_3 = "D_";
			_4 = "R";
			_5 = "F_";
			_6 = "R_";
			r.B("MoveAgs");
		}
		else if (r.UMove[3] == 'w' && r.LMove[1] == 'r')
		{
			_1 = "L";
			_2 = "L";
			_3 = "D";
			_4 = "F";
			_5 = "F";
			r.L("MoveAgs");
		}
		else if (r.UMove[3] == 'r' && r.LMove[1] == 'w')
		{
			_1 = "L";
			_2 = "F";
			r.L("MoveAgs");
		}


		else if (r.FMove[5] == 'r' && r.RMove[3] == 'w')
		{
			_1 = "F_";
			r.F_("MoveAgs");
		}
		else if (r.FMove[5] == 'w' && r.RMove[3] == 'r')
		{
			_1="R_";_2="D_";_3="R";_4="F";_5="F";
			r.R_("MoveAgs");
		}
		else if (r.RMove[5] == 'w' && r.BMove[5] == 'r')//asta
		{
			_1 = "R";
			_2 = "R";
			_3 = "F_";
			_4 = "R";
			_5 = "R";
			r.R("MoveAgs");
		}
		else if (r.RMove[5] == 'r' && r.BMove[5] == 'w')//verificat pana aici
		{
			_1 = "R";_2 = "D_";_3 = "R_";_4 = "F";_5="F";
			r.R("MoveAgs");
		}
		else if (r.FMove[3] == 'r' && r.LMove[5] == 'w')
		{
			_1 = "F";
			r.F("MoveAgs");
		}
		else if (r.FMove[3] == 'w' && r.LMove[5] == 'r')
		{
			_1 = "L";
			_2 = "D";
			_3 = "F";
			_4 = "F";
			r.L("MoveAgs");
		}
		else if (r.LMove[3] == 'r' && r.BMove[3] == 'w')
		{
			_1 = "L_";
			_2 = "D";
			_3 = "F";
			_4 = "F";
			r.L_("MoveAgs");
		}
		else if (r.LMove[3] == 'w' && r.BMove[3] == 'r')
		{
			_1 = "L";
			_2 = "L";
			_3 = "F";
			r.L("MoveAgs");
		}


		else if (r.FMove[7]=='r' && r.DMove[1]=='w')
		{
			_1="F";_2="F";
			r.F("MoveAgs");
		}
		else if (r.FMove[7]=='w' && r.DMove[1]=='r')//tested
		{
			_1="F_";_2="R_";_3="D_";_4="F";_5="R";_6="F";
			r.F_("MoveAgs");
		}
		else if (r.RMove[7]=='r' && r.DMove[5]=='w')
		{
			_1="D_";_2="F";_3="F";
			r.D_("MoveAgs");
		}
		else if (r.RMove[7]=='w' && r.DMove[5]=='r')
		{
			_1="R";_2="F_";
			r.R_("MoveAgs");
		}
		else if (r.LMove[7]=='w' && r.DMove[3]=='r')
		{
			_1="L_";_2="F";
			r.L_("MoveAgs");
		}
		else if (r.LMove[7]=='r' && r.DMove[3]=='w')
		{
			_1="D";_2="F";_3="F";
			r.D("MoveAgs");
		}
		else if (r.BMove[1]=='r' && r.DMove[7]=='w')
		{
			_1="D";_2="D";_3="F";_4="F";
			r.D("MoveAgs");
		}
		else if (r.BMove[1]=='w' && r.DMove[7]=='r')
		{
			_1="D_";_2="R";_3="F_";_4="R_";
			r.D_("MoveAgs");
		}




		//o-w
		else if (r.UMove[5]=='o' && r.RMove[1]=='w')
		{
			_1="R_";_2="F";_3="D";_4="F_";_5="R";_6="R";
			r.R_("MoveAgs");
		}
		else if (r.UMove[1]=='w' && r.BMove[7]=='o')
		{
			_1="B";_2="B";_3="D_";_4="R";_5="R";
			r.R("MoveAgs");
		}
		else if (r.UMove[1]=='o' && r.BMove[7]=='w')//tested
		{
			_1="B_";_2="R_";
			r.B_("MoveAgs");
		}
		else if (r.UMove[3]=='w' && r.LMove[1]=='o')
		{
			_1="L";_2="L";_3="D";_4="D";_5="R";_6="R";
			r.L("MoveAgs");
		}
		else if (r.UMove[3]=='o' && r.LMove[1]=='w')
		{
			_1="L";_2="L";_3="D";_4="F_";_5="R";_6="F";
			r.L("MoveAgs");
		}
		else if (r.UMove[7]=='w' && r.FMove[1]=='o')
		{
			_1="F";_2="F";_3="D";_4="R";_5="R";
			r.F("MoveAgs");
		}
		else if (r.UMove[7]=='o' && r.FMove[1]=='w')
		{
			_1="F";_2="R";
			r.F("MoveAgs");
		}


		else if (r.FMove[5]=='w' && r.RMove[3]=='o')
		{
			_1="R";
			r.R("MoveAgs");
		}
		else if (r.FMove[5]=='o' && r.RMove[3]=='w')
		{
			_1="R_";_2="D_";_3="F_";_4="R";_5="F";
			r.R_("MoveAgs");
		}
		else if (r.FMove[3]=='w' && r.LMove[5]=='o')
		{
			_1="F";_2="F";_3="R";_4="F_";_5="F";
			r.F("MoveAgs");
		}
		else if (r.FMove[3]=='o' && r.LMove[5]=='w')
		{
			_1="F_";_2="D";_3="F";_4="R";_5="R";
			r.F_("MoveAgs");
		}
		else if (r.RMove[5]=='o' && r.BMove[5]=='w')
		{
			_1="R_";//_2="D_";_3="R";_4="F";_5="F";
			r.R_("MoveAgs");
		}
		else if (r.RMove[5]=='w' && r.BMove[5]=='o')
		{
			_1="R";_2="R";_3="F_";_4="R_";_5="R_";
			r.R("MoveAgs");
		}
		else if (r.LMove[3]=='w' && r.BMove[3]=='o')
		{
			_1="L_";_2="D";_3="L";_4="F_";_5="R";_6="F";
			r.L_("MoveAgs");
		}
		else if (r.LMove[3]=='o' && r.BMove[3]=='w')
		{
			_1="L_";_2="D";_3="L";_4="D";_5="R";_6="R";
			r.L_("MoveAgs");
		}


		else if (r.FMove[7]=='o' && r.DMove[1]=='w')
		{
			_1="D";_2="R";_3="R";
			r.D("MoveAgs");
		}
		else if (r.FMove[7]=='w' && r.DMove[1]=='o')
		{
			_1="F_";_2="R";_3="F";
			r.F_("MoveAgs");
		}
		else if (r.RMove[7]=='o' && r.DMove[5]=='w')
		{
			_1="R";_2="R";
			r.R("MoveAgs");
		}
		else if (r.RMove[7]=='w' && r.DMove[5]=='o')
		{
			_1="R";_2="F";_3="D";_4="F_";_5="R";_6="R";
			r.R("MoveAgs");
		}
		else if (r.BMove[1]=='w' && r.DMove[7]=='o')//asta
		{
			_1="B";_2="R_";_3="B_";
			r.R("MoveAgs");
		}
		else if (r.BMove[1]=='o' && r.DMove[7]=='w')
		{
			_1="D_";_2="F";_3="F";
			r.D_("MoveAgs");
		}
		else if (r.LMove[7]=='o' && r.DMove[3]=='w')
		{
			_1="D";_2="D";_3="R";_4="R";
			r.D("MoveAgs");
		}
		else if (r.LMove[7]=='w' && r.DMove[3]=='o')
		{
			_1="D";_2="F_";_3="R";_4="F";
			r.D("MoveAgs");
		}




		//g-w
		else if (r.UMove[1]=='g' && r.BMove[7]=='w')
		{
			_1="B_";_2="R";_3="D";_4="R_";_5="B";_6="B";
			r.B_("MoveAgs");
		}
		else if (r.RMove[1]=='w' && r.UMove[5]=='g')
		{
			_1="R";_2="B";
			r.R("MoveAgs");
		}
		else if (r.RMove[1]=='g' && r.UMove[5]=='w')
		{
			_1="R";_2="R";_3="D";_4="B";_5="B";
			r.R("MoveAgs");
		}
		else if (r.UMove[7]=='w' && r.FMove[1]=='g')
		{
			_1="F";_2="F";_3="D";_4="D";_5="B";_6="B";
			r.F("MoveAgs");
		}
		else if (r.UMove[7]=='g' && r.FMove[1]=='w')
		{
			_1="F";_2="F";_3="D";_4="R_";_5="B";_6="R";
			r.F("MoveAgs");
		}
		else if (r.UMove[3]=='g' && r.LMove[1]=='w')
		{
			_1="L_";_2="B_";
			r.L_("MoveAgs");
		}
		else if (r.UMove[3]=='w' && r.LMove[1]=='g')
		{
			_1="L";_2="L";_3="D_";_4="B";_5="B";
			r.L("MoveAgs");
		}


		else if (r.RMove[5]=='w' && r.BMove[5]=='g')
		{
			_1="B";
			r.B("MoveAgs");
		}
		else if (r.RMove[5]=='g' && r.BMove[5]=='w')
		{
			_1="R";_2="D";_3="B";_4="B";
			r.R("MoveAgs");
		}
		else if (r.BMove[3]=='g' && r.LMove[3]=='w')
		{
			_1="B_";
			r.B_("MoveAgs");
		}
		else if (r.BMove[3]=='w' && r.LMove[3]=='g')
		{
			_1="L_";_2="D_";_3="B";_4="B";
			r.L_("MoveAgs");
		}
		else if (r.LMove[5]=='w' && r.FMove[3]=='g')
		{
			_1="L";_2="L";_3="B_";_4="L";_5="L";
			r.L("MoveAgs");
		}
		else if (r.LMove[5]=='g' && r.FMove[3]=='w')
		{
			_1="L";_2="D_";_3="L_";_4="B";_5="B";
			r.L("MoveAgs");
		}
		else if (r.RMove[3]=='w' && r.FMove[5]=='g')
		{
			_1="R";_2="R";_3="B";_4="R";_5="R";
			r.R("MoveAgs");
		}
		else if (r.RMove[3]=='g' && r.FMove[5]=='w')
		{
			_1="R_";_2="D";_3="R";_4="B";_5="B";
			r.R("MoveAgs");
		}


		else if (r.BMove[1]=='g' && r.DMove[7]=='w')
		{
			_1="B";_2="B";
			r.B("MoveAgs");
		}
		else if (r.BMove[1]=='w' && r.DMove[7]=='g')
		{
			_1="B";_2="R";_3="D";_4="R_";_5="B";_6="B";
			r.B("MoveAgs");
		}
		else if (r.LMove[7]=='g' && r.DMove[3]=='w')
		{
			_1="D_";_2="B";_3="B";
			r.D_("MoveAgs");
		}
		else if (r.LMove[7]=='w' && r.DMove[3]=='g')
		{
			_1="L";_2="B_";_3="L_";
			r.L("MoveAgs");
		}
		else if (r.FMove[7]=='g' && r.DMove[1]=='w')
		{
			_1="D";_2="D";_3="B";_4="B";
			r.D("MoveAgs");
		}
		else if (r.FMove[7]=='w' && r.DMove[1]=='g')
		{
			_1="D_";_2="L";_3="B_";_4="L_";
			r.D_("MoveAgs");
		}
		else if (r.RMove[7]=='g' && r.DMove[5]=='w')
		{
			_1="D";_2="B";_3="B";
			r.D("MoveAgs");
		}
		else if (r.RMove[7]=='w' && r.DMove[5]=='g')
		{
			_1="R_";_2="B";_3="R";
			r.R_("MoveAgs");
		}
		



		//b-w
		else if (r.LMove[1]=='w' && r.UMove[3]=='b')
		{
			_1="L";_2="L";_3="D";_4="F";_5="L_";_6="F_";
			r.L("MoveAgs");
		}
		else if (r.BMove[7]=='w' && r.UMove[1]=='b')
		{
			_1="B";_2="L";
			r.B("MoveAgs");
		}
		else if (r.BMove[7]=='b' && r.UMove[1]=='w')
		{
			_1="B";_2="B";_3="D";_4="L";_5="L";
			r.B("MoveAgs");
		}
		else if (r.UMove[5]=='w' && r.RMove[1]=='b')
		{
			_1="R";_2="R";_3="D";_4="D";_5="L";_6="L";
			r.R("MoveAgs");
		}
		else if (r.UMove[5]=='b' && r.RMove[1]=='w')
		{
			_1="R";_2="R";_3="D_";_4="F";_5="L_";_6="F_";
			r.R("MoveAgs");
		}
		else if (r.UMove[7]=='b' && r.FMove[1]=='w')
		{
			_1="F_";_2="L_";
			r.F_("MoveAgs");
		}
		else if (r.UMove[7]=='w' && r.FMove[1]=='b')
		{
			_1="F";_2="F";_3="D_";_4="L";_5="L";
			r.F("MoveAgs");
		}


		else if (r.LMove[5]=='b' && r.FMove[3]=='w')
		{
			_1="L_";
			r.L_("MoveAgs");
		}
		else if (r.LMove[5]=='w' && r.FMove[3]=='b')
		{
			_1="F_";_2="D_";_3="F";_4="L";_5="L";
			r.F_("MoveAgs");
		}
		else if (r.LMove[3]=='b' && r.BMove[3]=='w')
		{
			_1="L";
			r.L("MoveAgs");
		}
		else if (r.LMove[3]=='w' && r.BMove[3]=='b')
		{
			_1="B";_2="D";_3="B_";_4="L";_5="L";
			r.B("MoveAgs");
		}
		else if (r.FMove[5]=='b' && r.RMove[3]=='w')
		{
			_1="F";_2="D_";_3="F_";_4="L";_5="L";
			r.F("MoveAgs");
		}
		else if (r.FMove[5]=='w' && r.RMove[3]=='b')
		{
			_1="F";_2="F";_3="L_";_4="F";_5="F";
			r.F("MoveAgs");
		}
		else if (r.BMove[5]=='w' && r.RMove[5]=='b')
		{
			_1="B";_2="B";_3="L";_4="B";_5="B";
			r.B("MoveAgs");
		}
		else if (r.BMove[5]=='b' && r.RMove[5]=='w')
		{
			_1="B_";_2="D";_3="B";_4="L";_5="L";
			r.B_("MoveAgs");
		}
		

		else if (r.LMove[7]=='b' && r.DMove[3]=='w')
		{
			_1="L";_2="L";
			r.L("MoveAgs");
		}
		else if (r.LMove[7]=='w' && r.DMove[3]=='b')
		{
			_1="D";_2="F";_3="L_";_4="F_";
			r.D("MoveAgs");
		}
		else if (r.FMove[7]=='w' && r.DMove[1]=='b')
		{
			_1="F";_2="L_";_3="F_";
			r.F("MoveAgs");
		}
		else if (r.FMove[7]=='b' && r.DMove[1]=='w')
		{
			_1="D_";_2="L";_3="L";
			r.D_("MoveAgs");
		}
		else if (r.BMove[1]=='b' && r.DMove[7]=='w')
		{
			_1="D";_2="L";_3="L";
			r.D("MoveAgs");
		}
		else if (r.BMove[1]=='w' && r.DMove[7]=='b')
		{
			_1="B_";_2="L";_3="B";
			r.B_("MoveAgs");
		}
		else if (r.RMove[7]=='w' && r.DMove[5]=='b')
		{
			_1="D";_2="B_";_3="L";_4="B";
			r.D("MoveAgs");
		}
		else if (r.RMove[7]=='b' && r.DMove[5]=='w')
		{
			_1="D";_2="D";_3="L";_4="L";
			r.D("MoveAgs");
		}
    }











    public void SolveFirstColturi()
	{
		if (r.UMove[0]=='w' && r.UMove[1]=='w' && r.UMove[2]=='w' && r.UMove[3]=='w' && r.UMove[5]=='w' && r.UMove[6]=='w' && r.UMove[7]=='w' && r.FMove[0]=='r' && r.FMove[1]=='r' && r.FMove[2]=='r' && r.RMove[0]=='r' && r.RMove[1]=='r' && r.RMove[2]=='r' && r.LMove[0]=='b' && r.LMove[1]=='b' && r.LMove[2]=='b' && r.BMove[5]=='g' && r.BMove[6]=='g')
		{
			SolveStatus="SolveSecond";
			SolveSecond();
		}



		//r-o-w
		else if (r.UMove[8]=='r' && r.FMove[2]=='o')
		{
			_1="R_";_2="D_";_3="R";_4="D";_5="R_";_6="D_";_7="R";
			r.R_("MoveAgs");
		}
		else if (r.UMove[8]=='o' && r.FMove[2]=='w')
		{
			_1="R_";_2="D";_3="R";_4="D_";_5="R_";_6="D";_7="R";
			r.R_("MoveAgs");
		}
		else if (r.UMove[2]=='w' && r.RMove[2]=='r')
		{
			_1="B_";_2="D_";_3="B";_4="D_";_5="R_";_6="D";_7="R";
			r.B_("MoveAgs");
		}
		else if (r.UMove[2]=='r' && r.RMove[2]=='o')
		{
			_1="B_";_2="D_";_3="B";_4="R_";_5="D_";_6="R";
			r.B_("MoveAgs");
		}
		else if (r.UMove[2]=='o' && r.RMove[2]=='w')
		{
			_1="B_";_2="D_";_3="B";_4="R_";_5="D";_6="D";_7="R";_8="D";_9="R_";_10="D_";_11="R";
			r.B_("MoveAgs");
		}
		else if (r.UMove[0]=='w' && r.LMove[0]=='o')
		{
			_1="B";_2="D";_3="B_";_4="D";_5="R_";_6="D_";_7="R";
			r.B("MoveAgs");
		}
		else if (r.UMove[0]=='r' && r.LMove[0]=='w')
		{
			_1="B";_2="D";_3="B_";_4="D";_5="R_";_6="D";_7="D";_8="R";_9="D";_10="R_";_11="D_";_12="R";
			r.B("MoveAgs");
		}
		else if (r.UMove[0]=='o' && r.LMove[0]=='r')
		{
			_1="B";_2="D";_3="B_";_4="R_";_5="D";_6="R";
			r.B("MoveAgs");
		}
		else if (r.UMove[6]=='w' && r.FMove[0]=='o')
		{
			_1="L";_2="D";_3="L_";_4="R_";_5="D_";_6="R";
			r.L("MoveAgs");
		}
		else if (r.UMove[6]=='r' && r.FMove[0]=='w')
		{
			_1="L";_2="D";_3="L_";_4="R_";_5="D";_6="D";_7="R";_8="D";_9="R_";_10="D_";_11="R";
			r.L("MoveAgs");
		}
		else if (r.UMove[6]=='o' && r.FMove[0]=='r')
		{
			_1="L";_2="D";_3="L_";_4="D_";_5="R_";_6="D";_7="R";
			r.L("MoveAgs");
		}


		else if (r.FMove[8]=='w' && r.RMove[6]=='o')
		{
			_1="F";_2="D";_3="F_";
			r.F("MoveAgs");
		}
		else if (r.FMove[8]=='r' && r.RMove[6]=='w')
		{
			_1="R_";_2="D_";_3="R";
			r.R_("MoveAgs");
		}
		else if (r.FMove[8]=='o' && r.RMove[6]=='r')
		{
			_1="R_";_2="D";_3="D";_4="R";_5="D";_6="R_";_7="D_";_8="R";
			r.R_("MoveAgs");
		}
		else if (r.RMove[8]=='o' && r.DMove[8]=='w')
		{
			_1="D_";_2="R_";_3="D";_4="D";_5="R";_6="D";_7="R_";_8="D_";_9="R";
			r.D_("MoveAgs");
		}
		else if (r.RMove[8]=='r' && r.DMove[8]=='o')
		{
			_1="D_";_2="R_";_3="D_";_4="R";
			r.D_("MoveAgs");
		}
		else if (r.RMove[8]=='w' && r.DMove[8]=='r')
		{
			_1="D_";_2="F";_3="D";_4="F_";
			r.D_("MoveAgs");
		}
		else if (r.LMove[6]=='w' && r.DMove[6]=='o')
		{
			_1="D";_2="D";_3="R_";_4="D_";_5="R";
			r.D("MoveAgs");
		}
		else if (r.LMove[6]=='o' && r.DMove[6]=='r')
		{
			_1="D";_2="D";_3="F";_4="D";_5="F_";
			r.D("MoveAgs");
		}
		else if (r.LMove[6]=='r' && r.DMove[6]=='w')
		{
			_1="D";_2="D";_3="R_";_4="D";_5="D";_6="R";_7="D";_8="R_";_9="D_";_10="R";
			r.D("MoveAgs");
		}
		else if (r.FMove[6]=='o' && r.LMove[8]=='w')
		{
			_1="R_";_2="D";_3="R";
			r.R_("MoveAgs");
		}
		else if (r.FMove[6]=='r' && r.LMove[8]=='o')
		{
			_1="D";_2="R_";_3="D";_4="D";_5="R";_6="D";_7="R_";_8="D_";_9="R";
			r.D("MoveAgs");
		}
		else if (r.FMove[6]=='w' && r.LMove[8]=='r')
		{
			_1="D";_2="R_";_3="D_";_4="R";
			r.D("MoveAgs");
		}


		


		//w-o-g
		else if (r.UMove[8]=='w' && r.FMove[2]=='o')
		{
			_1="F";_2="D";_3="F_";_4="D";_5="R";_6="D_";_7="R_";
			r.F("MoveAgs");
		}
		else if (r.UMove[8]=='o' && r.FMove[2]=='g')
		{
			_1="R_";_2="D";_3="D";_4="R";_5="R";_6="D_";_7="R_";
			r.R_("MoveAgs");
		}
		else if (r.UMove[8]=='g' && r.FMove[2]=='w')
		{
			_1="R_";_2="D";_3="R";_4="B_";_5="D";_6="B";
			r.R_("MoveAgs");
		}
		else if (r.UMove[6]=='w' && r.FMove[0]=='g')
		{
			_1="L";_2="D";_3="L_";_4="D";_5="B_";_6="D_";_7="B";
			r.L("MoveAgs");
		}
		else if (r.UMove[6]=='g' && r.FMove[0]=='o')
		{
			_1="L";_2="D";_3="L_";_4="B_";_5="D";_6="B";
			r.L("MoveAgs");
		}
		else if (r.UMove[6]=='o' && r.FMove[0]=='w')
		{
			_1="F_";_2="D";_3="D";_4="F";_5="B_";_6="D_";_7="B";
			r.F_("MoveAgs");
		}
		else if (r.UMove[0]=='w' && r.LMove[0]=='g')
		{
			_1="L_";_2="D_";_3="L";_4="D_";_5="B_";_6="D";_7="B";
			r.L_("MoveAgs");
		}
		else if (r.UMove[0]=='o' && r.LMove[0]=='w')
		{
			_1="L_";_2="D_";_3="L";_4="B_";_5="D_";_6="B";
			r.L_("MoveAgs");
		}
		else if (r.UMove[0]=='g' && r.LMove[0]=='o')
		{
			_1="B";_2="D";_3="D";_4="B";_5="B";_6="D";_7="B";
			r.B("MoveAgs");
		}
		else if (r.UMove[2]=='o' && r.RMove[2]=='g')
		{
			_1="B_";_2="D_";_3="B";_4="D";_5="B_";_6="D_";_7="B";
			r.B_("MoveAgs");
		}
		else if (r.UMove[2]=='g' && r.RMove[2]=='w')
		{
			_1="B_";_2="D";_3="B";_4="D_";_5="B_";_6="D";_7="B";
			r.B_("MoveAgs");
		}
		
//!!!nu fac algoritmi, doar mut cuburile de jos spre sus si dupa se misca automat cu algor de mai sus
		else if ((r.RMove[8]=='w' && r.BMove[2]=='g') || (r.RMove[8]=='g' && r.BMove[2]=='o') || (r.RMove[8]=='o' && r.BMove[2]=='w'))
		{
			_1="D_";_2="B_";_3="D";_4="B";
			r.D_("MoveAgs");
		}
		else if ((r.FMove[8]=='w' && r.RMove[6]=='g') || (r.FMove[8]=='g' && r.RMove[6]=='o') || (r.FMove[8]=='o' && r.RMove[6]=='w'))
		{
			_1="D_";_2="R_";_3="D";_4="R";
			r.D_("MoveAgs");
		}
		else if ((r.LMove[8]=='w' && r.FMove[6]=='g') || (r.LMove[8]=='g' && r.FMove[6]=='o') || (r.LMove[8]=='o' && r.FMove[6]=='w'))
		{
			_1="D_";_2="F_";_3="D";_4="F";
			r.D_("MoveAgs");
		}
		else if ((r.BMove[0]=='w' && r.LMove[6]=='g') || (r.BMove[0]=='g' && r.LMove[6]=='o') || (r.BMove[0]=='o' && r.LMove[6]=='w'))
		{
			_1="D_";_2="L_";_3="D";_4="L";
			r.D_("MoveAgs");
		}





		//w-g-b
		else if (r.UMove[0]=='g' && r.LMove[0]=='w')
		{
			_1="L_";_2="D_";_3="L";_4="D";_5="L_";_6="D_";_7="L";
			r.L_("MoveAgs");
		}
		else if (r.UMove[0]=='b' && r.LMove[0]=='g')
		{
			_1="L_";_2="D";_3="L";_4="D_";_5="L_";_6="D";_7="L";
			r.L_("MoveAgs");
		}
		else if (r.UMove[2]=='w' && r.RMove[2]=='g')
		{
			_1="B_";_2="D_";_3="B";_4="D";_5="L_";_6="D";_7="L";
			r.B_("MoveAgs");
		}
		else if (r.UMove[2]=='g' && r.RMove[2]=='b')
		{
			_1="B_";_2="D_";_3="B";_4="D";_5="D";_6="L_";_7="D_";_8="L";
			r.B_("MoveAgs");
		}
		else if (r.UMove[2]=='b' && r.RMove[2]=='w')
		{
			_1="B_";_2="D";_3="B";_4="L_";_5="D";_6="L";
			r.B_("MoveAgs");
		}
		else if (r.UMove[8]=='w' && r.FMove[2]=='g')
		{
			_1="R_";_2="D_";_3="R";_4="D_";_5="B";_6="D";_7="B_";
			r.R_("MoveAgs");
		}
		else if (r.UMove[8]=='b' && r.FMove[2]=='w')
		{
			_1="R_";_2="D_";_3="R";_4="D_";_5="B";_6="D";_7="D";_8="B_";_9="D_";_10="B";_11="D";_12="B_";
			r.R_("MoveAgs");
		}
		else if (r.UMove[8]=='g' && r.FMove[2]=='b')
		{
			_1="R_";_2="D_";_3="R";_4="D_";_5="L_";_6="D_";_7="L";
			r.R_("MoveAgs");
		}
		else if (r.UMove[6]=='w' && r.FMove[0]=='b')
		{
			_1="F_";_2="D_";_3="F";_4="B";_5="D";_6="B_";
			r.F_("MoveAgs");
		}
		else if (r.UMove[6]=='b' && r.FMove[0]=='g')
		{
			_1="F_";_2="D_";_3="F";_4="L_";_5="D";_6="D";_7="L";_8="D";_9="L_";_10="D_";_11="L";
			r.F_("MoveAgs");
		}
		else if (r.UMove[6]=='g' && r.FMove[0]=='w')
		{
			_1="F_";_2="D_";_3="F";_4="L_";_5="D_";_6="L";
			r.F_("MoveAgs");
		}

//!!!nu fac algoritmi, doar mut cuburile de jos spre sus si dupa se misca automat cu algor de mai sus
		else if ((r.RMove[8]=='w' && r.BMove[2]=='b') || (r.RMove[8]=='b' && r.BMove[2]=='g') || (r.RMove[8]=='g' && r.BMove[2]=='w'))
		{
			_1="D_";_2="B_";_3="D";_4="B";
			r.D_("MoveAgs");
		}
		else if ((r.FMove[8]=='w' && r.RMove[6]=='b') || (r.FMove[8]=='b' && r.RMove[6]=='g') || (r.FMove[8]=='g' && r.RMove[6]=='w'))
		{
			_1="D_";_2="R_";_3="D";_4="R";
			r.D_("MoveAgs");
		}
		else if ((r.LMove[8]=='w' && r.FMove[6]=='b') || (r.LMove[8]=='b' && r.FMove[6]=='g') || (r.LMove[8]=='g' && r.FMove[6]=='w'))
		{
			_1="D_";_2="F_";_3="D";_4="F";
			r.D_("MoveAgs");
		}
		else if ((r.BMove[0]=='w' && r.LMove[6]=='b') || (r.BMove[0]=='b' && r.LMove[6]=='g') || (r.BMove[0]=='g' && r.LMove[6]=='w'))
		{
			_1="D_";_2="L_";_3="D";_4="L";
			r.D_("MoveAgs");
		}




		//white-red-blue
		else if (r.UMove[6]=='r' && r.FMove[0]=='b')
		{
			_1="F_";_2="D";_3="F";_4="D_";_5="F_";_6="D";_7="F";
			r.F_("MoveAgs");
		}
		else if (r.UMove[6]=='b' && r.FMove[0]=='w')
		{
			_1="F_";_2="D_";_3="F";_4="D";_5="F_";_6="D_";_7="F";
			r.F_("MoveAgs");
		}
		else if (r.UMove[8]=='w' && r.FMove[2]=='b')
		{
			_1="R_";_2="D";_3="D";_4="F_";_5="D";_6="F";
			r.R_("MoveAgs");
		}
		else if (r.UMove[8]=='b' && r.FMove[2]=='r')
		{
			_1="R_";_2="D_";_3="R";_4="F_";_5="D_";_6="F";
			r.R_("MoveAgs");
		}
		else if (r.UMove[8]=='r' && r.FMove[2]=='w')
		{
			_1="R_";_2="D_";_3="R";_4="F_";_5="D";_6="D";_7="F";_8="D";_9="F_";_10="D_";_11="F";
			r.R_("MoveAgs");
		}
		else if (r.UMove[2]=='w' && r.RMove[2]=='b')
		{
			_1="B_";_2="D_";_3="B";_4="D_";_5="L";_6="D";_7="L_";
			r.B_("MoveAgs");
		}
		else if (r.UMove[2]=='b' && r.RMove[2]=='r')
		{
			_1="B_";_2="D_";_3="B";_4="D_";_5="F_";_6="D_";_7="F";
			r.B_("MoveAgs");
		}
		else if (r.UMove[2]=='r' && r.RMove[2]=='w')
		{
			_1="B_";_2="D_";_3="B";_4="D_";_5="F_";_6="D";_7="D";_8="F";_9="D";_10="F_";_11="D_";_12="F";
			r.B_("MoveAgs");
		}
		else if (r.UMove[0]=='w' && r.LMove[0]=='r')
		{
			_1="B";_2="D";_3="B_";_4="F_";_5="D_";_6="F";
			r.B("MoveAgs");
		}
		else if (r.UMove[0]=='r' && r.LMove[0]=='b')
		{
			_1="B";_2="D";_3="B_";_4="L";_5="D";_6="L_";
			r.B("MoveAgs");
		}
		else if (r.UMove[0]=='b' && r.LMove[0]=='w')
		{
			_1="B";_2="D";_3="B_";_4="F_";_5="D";_6="D";_7="F";_8="D";_9="F_";_10="D_";_11="F";
			r.B("MoveAgs");
		}

//!!!nu fac algoritmi, doar mut cuburile de jos spre sus si dupa se misca automat cu algor de mai sus
		else if ((r.RMove[8]=='w' && r.BMove[2]=='r') || (r.RMove[8]=='r' && r.BMove[2]=='b') || (r.RMove[8]=='b' && r.BMove[2]=='w'))
		{
			_1="D_";_2="B_";_3="D";_4="B";
			r.D_("MoveAgs");
		}
		else if ((r.FMove[8]=='w' && r.RMove[6]=='r') || (r.FMove[8]=='r' && r.RMove[6]=='b') || (r.FMove[8]=='b' && r.RMove[6]=='w'))
		{
			_1="D_";_2="R_";_3="D";_4="R";
			r.D_("MoveAgs");
		}
		else if ((r.LMove[8]=='w' && r.FMove[6]=='r') || (r.LMove[8]=='r' && r.FMove[6]=='b') || (r.LMove[8]=='b' && r.FMove[6]=='w'))
		{
			_1="D_";_2="F_";_3="D";_4="F";
			r.D_("MoveAgs");
		}
		else if ((r.BMove[0]=='w' && r.LMove[6]=='r') || (r.BMove[0]=='r' && r.LMove[6]=='b') || (r.BMove[0]=='b' && r.LMove[6]=='w'))
		{
			_1="D_";_2="L_";_3="D";_4="L";
			r.D_("MoveAgs");
		}

		else {SolveStatus="SolveSecond";SolveSecond();}///////////////////////////////////////////////
		//////////////////////////////////////////////////////////////////////////



















	}

	private void SolveSecond()
	{
		if (r.FMove[5]=='r' && r.FMove[3]=='r' && r.RMove[3]=='o' && r.RMove[5]=='o' && r.LMove[3]=='b' && r.LMove[5]=='b' && r.BMove[3]=='g')
			SolveStatus = "SolveThird";



		else if (r.FMove[7]=='o' && r.DMove[1]=='r')
		{
			_1="D";_2="D";
			r.D("MoveAgs");
		}
		else if (r.RMove[7]=='o' && r.DMove[5]=='r')
		{
			_1="D";
			r.D("MoveAgs");
		}
		else if (r.LMove[7]=='o' && r.DMove[3]=='r')
		{
			_1="D_";
			r.D_("MoveAgs");
		}
		else if (r.BMove[1]=='o' && r.DMove[7]=='r')
		{
			_1="F";_2="D_";_3="F_";_4="D_";_5="R_";_6="D";_7="R";
			r.F("MoveAgs");
		}//mai sunt cazuri
	}
}
