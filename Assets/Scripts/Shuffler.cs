using UnityEngine;

public class Shuffler : MonoBehaviour
{
    public MainScript refScr;
	public CurrentMove refCrM;
	public Solver refSol;
	public string whichMoveForShuffle;
	private int K=0;

	public void MoveCubeForShuffle()
	{
		switch (whichMoveForShuffle)
		{
            case "R":
                refScr.R("UpdateShuffleCube");
				refCrM.currentMoveVar = "Shuffle Move: R";
                break;
            case "R_":
                refScr.R_("UpdateShuffleCube");
				refCrM.currentMoveVar = "Shuffle Move: R'";
                break;
            case "F":
                refScr.F("UpdateShuffleCube");
				refCrM.currentMoveVar = "Shuffle Move: F";
                break;
            case "F_":
                refScr.F_("UpdateShuffleCube");
				refCrM.currentMoveVar = "Shuffle Move: F'";
                break;
            case "U":
                refScr.U("UpdateShuffleCube");
				refCrM.currentMoveVar = "Shuffle Move: U";
                break;
            case "U_":
                refScr.U_("UpdateShuffleCube");
				refCrM.currentMoveVar = "Shuffle Move: U'";
                break;
            case "L":
                refScr.L("UpdateShuffleCube");
				refCrM.currentMoveVar = "Shuffle Move: L";
                break;
            case "L_":
                refScr.L_("UpdateShuffleCube");
				refCrM.currentMoveVar = "Shuffle Move: L'";
                break;
            case "B":
                refScr.B("UpdateShuffleCube");
				refCrM.currentMoveVar = "Shuffle Move: B";
                break;
            case "B_":
                refScr.B_("UpdateShuffleCube");
				refCrM.currentMoveVar = "Shuffle Move: B'";
                break;
            case "D":
                refScr.D("UpdateShuffleCube");
				refCrM.currentMoveVar = "Shuffle Move: D";
                break;
            case "D_":
                refScr.D_("UpdateShuffleCube");
				refCrM.currentMoveVar = "Shuffle Move: D'";
                break;
		}
	}

	public void ShuffleCube()
	{
		if (K < 20)
		{
			switch (Random.Range(1, 13))
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
