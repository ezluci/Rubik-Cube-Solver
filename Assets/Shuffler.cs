using UnityEngine;

public class Shuffler : MonoBehaviour
{
    public MainScript refScr;
	public Solver refSol;
	public string whichMoveForShuffle;
	private int K=0;

	public void MoveCubeForShuffle()
	{
		switch (whichMoveForShuffle)
		{
            case "R":
                refScr.R("UpdateShuffleCube");
                break;
            case "R_":
                refScr.R_("UpdateShuffleCube");
                break;
            case "F":
                refScr.F("UpdateShuffleCube");
                break;
            case "F_":
                refScr.F_("UpdateShuffleCube");
                break;
            case "U":
                refScr.U("UpdateShuffleCube");
                break;
            case "U_":
                refScr.U_("UpdateShuffleCube");
                break;
            case "L":
                refScr.L("UpdateShuffleCube");
                break;
            case "L_":
                refScr.L_("UpdateShuffleCube");
                break;
            case "B":
                refScr.B("UpdateShuffleCube");
                break;
            case "B_":
                refScr.B_("UpdateShuffleCube");
                break;
            case "D":
                refScr.D("UpdateShuffleCube");
                break;
            case "D_":
                refScr.D_("UpdateShuffleCube");
                break;
		}
	}

	public void ShuffleCube()
	{
		if (K < 20)
		{
			switch (UnityEngine.Random.Range(1, 13))
			{
			case 1:
				whichMoveForShuffle = "R";
				break;
			case 2:
				whichMoveForShuffle = "R_";
				break;
			case 3:
				whichMoveForShuffle = "F";
				break;
			case 4:
				whichMoveForShuffle = "F_";
				break;
			case 5:
				whichMoveForShuffle = "U";
				break;
			case 6:
				whichMoveForShuffle = "U_";
				break;
			case 7:
				whichMoveForShuffle = "L";
				break;
			case 8:
				whichMoveForShuffle = "L_";
				break;
			case 9:
				whichMoveForShuffle = "B";
				break;
			case 10:
				whichMoveForShuffle = "B_";
				break;
			case 11:
				whichMoveForShuffle = "D";
				break;
			case 12:
				whichMoveForShuffle = "D_";
				break;
			}
			Debug.Log("Shuffler: " + K);
			K++;
			refScr.whatDoUWannaDo = "FixedUpdateMoveCubeForShuffle";
		}
		else
		{
			Debug.Log("Shuffler: Done");
			Debug.Log("Solver: Begin");
			refSol.SolveFirstMargini();
		}
	}
}
