using UnityEngine;
public class Script : MonoBehaviour
{
    string whatDoUWannaDo = "UpdateShuffleCube";
    int ShuffleStatus = 0;
    string whichMove = "";
    public bool initializeMove = false;
    //public Vector3 eul; //variabila pentru salvat rotatia eul la inceput
    //public Quaternion quat; //variabila pentru salvat rotatia quat la inceput.
    GameObject Obj;
    Quaternion deltaRotation;
    public char[] UMove = {'w','w','w','w','w','w','w','w','w'};
    public char[] LMove = {'b','b','b','b','b','b','b','b','b'};
    public char[] FMove = {'r','r','r','r','r','r','r','r','r'};
    public char[] RMove = {'o','o','o','o','o','o','o','o','o'};
    public char[] DMove = {'y','y','y','y','y','y','y','y','y'};
    public char[] BMove = {'g','g','g','g','g','g','g','g','g'};
    char keepMove,keepMove2;

    void ShuffleCube()
    {
        if (ShuffleStatus < 40)
        {
            Debug.Log(ShuffleStatus);
            switch (Random.Range(1,13))
            {
                case 1:
                    whichMove="R";
                    break;
                case 2:
                    whichMove="R_";
                    break;
                case 3:
                    whichMove="F";
                    break;
                case 4:
                    whichMove="F_";
                    break;
                case 5:
                    whichMove="U";
                    break;
                case 6:
                    whichMove="U_";
                    break;
                case 7:
                    whichMove="L";
                    break;
                case 8:
                    whichMove="L_";
                    break;
                case 9:
                    whichMove="B";
                    break;
                case 10:
                    whichMove="B_";
                    break;
                case 11:
                    whichMove="D";
                    break;
                case 12:
                    whichMove="D_";
                    break;
                default:
                    Debug.Log("ERORERERRER");
                    break;
            }
            ShuffleStatus++;
            whatDoUWannaDo="FixedUpdateMoveCube";
        }
        else
        {
            Debug.Log("shuffle complete");
            whatDoUWannaDo="UpdateSolve";
        }
    }

    void Solve()
    {

    }

    void MoveCube()
    {
        switch (whichMove)
        {
            case "R":
                R();
                break;
            case "R_":
                R_();
                break;
            case "F":
                F();
                break;
            case "F_":
                F_();
                break;
            case "U":
                U();
                break;
            case "U_":
                U_();
                break;
            case "L":
                L();
                break;
            case "L_":
                L_();
                break;
            case "B":
                B();    
                break;
            case "B_":
                B_();
                break;
            case "D":
                D();
                break;
            case "D_":
                D_();
                break;
            default:
                Debug.Log("defaultaa");
                break;
        }
    }

    void MoveChildsAndRearrangeColors(string Move)
    {
        if (Move=="R_" || Move=="R")
        {
            foreach (GameObject childObjs in GameObject.FindGameObjectsWithTag("Respawn"))
            {
                if (1.04 <= childObjs.transform.parent.position.x && childObjs.transform.parent.position.x <= 1.06)
                {
                    Quaternion f = Quaternion.Euler(childObjs.transform.parent.eulerAngles.x, childObjs.transform.parent.eulerAngles.y, childObjs.transform.parent.eulerAngles.z);
                    Instantiate(childObjs.transform.parent, childObjs.transform.parent.position, f).name=childObjs.transform.parent.name;
                    Destroy(childObjs.transform.parent.gameObject);
                }
            }
            if (Move=="R")
            {
                keepMove=UMove[2];  //
                UMove[2]=FMove[2];
                keepMove2=BMove[2];
                BMove[2]=keepMove;
                keepMove=DMove[2];
                DMove[2]=keepMove2;
                FMove[2]=keepMove;
                keepMove=UMove[5];  //
                UMove[5]=FMove[5];
                keepMove2=BMove[5];
                BMove[5]=keepMove;
                keepMove=DMove[5];
                DMove[5]=keepMove2;
                FMove[5]=keepMove;
                keepMove=UMove[8];  //
                UMove[8]=FMove[8];
                keepMove2=BMove[8];
                BMove[8]=keepMove;
                keepMove=DMove[8];
                DMove[8]=keepMove2;
                FMove[8]=keepMove;

                keepMove=RMove[2];  //colturi.mij
                RMove[2]=RMove[0];
                keepMove2=RMove[8];
                RMove[8]=keepMove;
                keepMove=RMove[6];
                RMove[6]=keepMove2;
                RMove[0]=keepMove;
                keepMove=RMove[1];  //margini.mij
                RMove[1]=RMove[3];
                keepMove2=RMove[5];
                RMove[5]=keepMove;
                keepMove=RMove[7];
                RMove[7]=keepMove2;
                RMove[3]=keepMove;
            }
            else
            {
                keepMove=UMove[2];  //
                UMove[2]=BMove[2];
                keepMove2=FMove[2];
                FMove[2]=keepMove;
                keepMove=DMove[2];
                DMove[2]=keepMove2;
                BMove[2]=keepMove;
                keepMove=UMove[5];  //
                UMove[5]=BMove[5];
                keepMove2=FMove[5];
                FMove[5]=keepMove;
                keepMove=DMove[5];
                DMove[5]=keepMove2;
                BMove[5]=keepMove;
                keepMove=UMove[8];  //
                UMove[8]=BMove[8];
                keepMove2=FMove[8];
                FMove[8]=keepMove;
                keepMove=DMove[8];
                DMove[8]=keepMove2;
                BMove[8]=keepMove;

                keepMove=RMove[2];  //colturi.mij
                RMove[2]=RMove[8];
                keepMove2=RMove[0];
                RMove[0]=keepMove;
                keepMove=RMove[6];
                RMove[6]=keepMove2;
                RMove[8]=keepMove;
                keepMove=RMove[1];  //margini.mij
                RMove[1]=RMove[5];
                keepMove2=RMove[3];
                RMove[3]=keepMove;
                keepMove=RMove[7];
                RMove[7]=keepMove2;
                RMove[5]=keepMove;
            }
        }
        else if (Move=="F_" || Move=="F")
        {
            foreach (GameObject childObjs in GameObject.FindGameObjectsWithTag("Respawn"))
            {
                if (-0.01 <= childObjs.transform.parent.position.z && childObjs.transform.parent.position.z <= 0.01)
                {
                    Quaternion f = Quaternion.Euler(childObjs.transform.parent.eulerAngles.x, childObjs.transform.parent.eulerAngles.y, childObjs.transform.parent.eulerAngles.z);
                    Instantiate(childObjs.transform.parent, childObjs.transform.parent.position, f).name=childObjs.transform.parent.name;
                    Destroy(childObjs.transform.parent.gameObject);
                }
            }
            if (Move=="F")
            {
                keepMove=UMove[8];  //
                UMove[8]=LMove[2];
                keepMove2=RMove[6];
                RMove[6]=keepMove;
                keepMove=DMove[0];
                DMove[0]=keepMove2;
                LMove[2]=keepMove;
                keepMove=UMove[7];  //
                UMove[7]=LMove[5];
                keepMove2=RMove[3];
                RMove[3]=keepMove;
                keepMove=DMove[1];
                DMove[1]=keepMove2;
                LMove[5]=keepMove;
                keepMove=UMove[6];  //
                UMove[6]=LMove[8];
                keepMove2=RMove[0];
                RMove[0]=keepMove;
                keepMove=DMove[2];
                DMove[2]=keepMove2;
                LMove[8]=keepMove;

                keepMove=FMove[2];  //colturi.mij
                FMove[2]=FMove[0];
                keepMove2=FMove[8];
                FMove[8]=keepMove;
                keepMove=FMove[6];
                FMove[6]=keepMove2;
                FMove[0]=keepMove;
                keepMove=FMove[1];  //margini.mij
                FMove[1]=FMove[3];
                keepMove2=FMove[5];
                FMove[5]=keepMove;
                keepMove=FMove[7];
                FMove[7]=keepMove2;
                FMove[3]=keepMove;
            }
            else
            {
                keepMove=UMove[8];  //
                UMove[8]=RMove[6];
                keepMove2=LMove[2];
                LMove[2]=keepMove;
                keepMove=DMove[0];
                DMove[0]=keepMove2;
                RMove[6]=keepMove;
                keepMove=UMove[7];  //
                UMove[7]=RMove[3];
                keepMove2=LMove[5];
                LMove[5]=keepMove;
                keepMove=DMove[1];
                DMove[1]=keepMove2;
                RMove[3]=keepMove;
                keepMove=UMove[6];  //
                UMove[6]=RMove[0];
                keepMove2=LMove[8];
                LMove[8]=keepMove;
                keepMove=DMove[2];
                DMove[2]=keepMove2;
                RMove[0]=keepMove;

                keepMove=FMove[2];  //colturi.mij
                FMove[2]=FMove[8];
                keepMove2=FMove[0];
                FMove[0]=keepMove;
                keepMove=FMove[6];
                FMove[6]=keepMove2;
                FMove[8]=keepMove;
                keepMove=FMove[1];  //margini.mij
                FMove[1]=FMove[5];
                keepMove2=FMove[3];
                FMove[3]=keepMove;
                keepMove=FMove[7];
                FMove[7]=keepMove2;
                FMove[5]=keepMove;
            }
        }
        else if (Move=="U_" || Move=="U")
        {
            foreach (GameObject childObjs in GameObject.FindGameObjectsWithTag("Respawn"))
            {
                if (5.09 <= childObjs.transform.parent.position.y && childObjs.transform.parent.position.y <= 5.11)
                {
                    Quaternion f = Quaternion.Euler(childObjs.transform.parent.eulerAngles.x, childObjs.transform.parent.eulerAngles.y, childObjs.transform.parent.eulerAngles.z);
                    Instantiate(childObjs.transform.parent, childObjs.transform.parent.position, f).name=childObjs.transform.parent.name;
                    Destroy(childObjs.transform.parent.gameObject);
                }
            }
            if (Move=="U")
            {
                keepMove=RMove[2];  //
                RMove[2]=BMove[6];
                keepMove2=FMove[2];
                FMove[2]=keepMove;
                keepMove=LMove[2];
                LMove[2]=keepMove2;
                BMove[6]=keepMove;
                keepMove=RMove[1];  //
                RMove[1]=BMove[7];
                keepMove2=FMove[1];
                FMove[1]=keepMove;
                keepMove=LMove[1];
                LMove[1]=keepMove2;
                BMove[7]=keepMove;
                keepMove=RMove[0];  //
                RMove[0]=BMove[8];
                keepMove2=FMove[0];
                FMove[0]=keepMove;
                keepMove=LMove[0];
                LMove[0]=keepMove2;
                BMove[8]=keepMove;

                keepMove=UMove[2];  //colturi.mij
                UMove[2]=UMove[0];
                keepMove2=UMove[8];
                UMove[8]=keepMove;
                keepMove=UMove[6];
                UMove[6]=keepMove2;
                UMove[0]=keepMove;
                keepMove=UMove[1];  //margini.mij
                UMove[1]=UMove[3];
                keepMove2=UMove[5];
                UMove[5]=keepMove;
                keepMove=UMove[7];
                UMove[7]=keepMove2;
                UMove[3]=keepMove;
            }
            else
            {
                keepMove=RMove[2];  //
                RMove[2]=FMove[2];
                keepMove2=BMove[6];
                BMove[6]=keepMove;
                keepMove=LMove[2];
                LMove[2]=keepMove2;
                FMove[2]=keepMove;
                keepMove=RMove[1];  //
                RMove[1]=FMove[1];
                keepMove2=BMove[7];
                BMove[7]=keepMove;
                keepMove=LMove[1];
                LMove[1]=keepMove2;
                FMove[1]=keepMove;
                keepMove=RMove[0];  //
                RMove[0]=FMove[0];
                keepMove2=BMove[8];
                BMove[8]=keepMove;
                keepMove=LMove[0];
                LMove[0]=keepMove2;
                FMove[0]=keepMove;

                keepMove=UMove[2];  //colturi.mij
                UMove[2]=UMove[8];
                keepMove2=UMove[0];
                UMove[0]=keepMove;
                keepMove=UMove[6];
                UMove[6]=keepMove2;
                UMove[8]=keepMove;
                keepMove=UMove[1];  //margini.mij
                UMove[1]=UMove[5];
                keepMove2=UMove[3];
                UMove[3]=keepMove;
                keepMove=UMove[7];
                UMove[7]=keepMove2;
                UMove[5]=keepMove;
            }
        }
        else if (Move=="L_" || Move=="L")
        {
            foreach (GameObject childObjs in GameObject.FindGameObjectsWithTag("Respawn"))
            {
                if (-1.06 <= childObjs.transform.parent.position.x && childObjs.transform.parent.position.x <= -1.04)
                {
                    Quaternion f = Quaternion.Euler(childObjs.transform.parent.eulerAngles.x, childObjs.transform.parent.eulerAngles.y, childObjs.transform.parent.eulerAngles.z);
                    Instantiate(childObjs.transform.parent, childObjs.transform.parent.position, f).name=childObjs.transform.parent.name;
                    Destroy(childObjs.transform.parent.gameObject);
                }
            }
            if (Move=="L")
            {
                keepMove=UMove[0];  //
                UMove[0]=BMove[0];
                keepMove2=FMove[0];
                FMove[0]=keepMove;
                keepMove=DMove[0];
                DMove[0]=keepMove2;
                BMove[0]=keepMove;
                keepMove=UMove[3];  //
                UMove[3]=BMove[3];
                keepMove2=FMove[3];
                FMove[3]=keepMove;
                keepMove=DMove[3];
                DMove[3]=keepMove2;
                BMove[3]=keepMove;
                keepMove=UMove[6];  //
                UMove[6]=BMove[6];
                keepMove2=FMove[6];
                FMove[6]=keepMove;
                keepMove=DMove[6];
                DMove[6]=keepMove2;
                BMove[6]=keepMove;

                keepMove=LMove[2];  //colturi.mij
                LMove[2]=LMove[0];
                keepMove2=LMove[8];
                LMove[8]=keepMove;
                keepMove=LMove[6];
                LMove[6]=keepMove2;
                LMove[0]=keepMove;
                keepMove=LMove[1];  //margini.mij
                LMove[1]=LMove[3];
                keepMove2=LMove[5];
                LMove[5]=keepMove;
                keepMove=LMove[7];
                LMove[7]=keepMove2;
                LMove[3]=keepMove;
            }
            else
            {
                keepMove=UMove[0];  //
                UMove[0]=FMove[0];
                keepMove2=BMove[0];
                BMove[0]=keepMove;
                keepMove=DMove[0];
                DMove[0]=keepMove2;
                FMove[0]=keepMove;
                keepMove=UMove[3];  //
                UMove[3]=FMove[3];
                keepMove2=BMove[3];
                BMove[3]=keepMove;
                keepMove=DMove[3];
                DMove[3]=keepMove2;
                FMove[3]=keepMove;
                keepMove=UMove[6];  //
                UMove[6]=FMove[6];
                keepMove2=BMove[6];
                BMove[6]=keepMove;
                keepMove=DMove[6];
                DMove[6]=keepMove2;
                FMove[6]=keepMove;
                
                keepMove=LMove[2];  //colturi.mij
                LMove[2]=LMove[8];
                keepMove2=LMove[0];
                LMove[0]=keepMove;
                keepMove=LMove[6];
                LMove[6]=keepMove2;
                LMove[8]=keepMove;
                keepMove=LMove[1];  //margini.mij
                LMove[1]=LMove[5];
                keepMove2=LMove[3];
                LMove[3]=keepMove;
                keepMove=LMove[7];
                LMove[7]=keepMove2;
                LMove[5]=keepMove;
            }
        }  
        else if (Move=="B_" || Move=="B")
        {
            foreach (GameObject childObjs in GameObject.FindGameObjectsWithTag("Respawn"))
            {
                if (2.09 <= childObjs.transform.parent.position.z && childObjs.transform.parent.position.z <= 2.11)
                {
                    Quaternion f = Quaternion.Euler(childObjs.transform.parent.eulerAngles.x, childObjs.transform.parent.eulerAngles.y, childObjs.transform.parent.eulerAngles.z);
                    Instantiate(childObjs.transform.parent, childObjs.transform.parent.position, f).name=childObjs.transform.parent.name;
                    Destroy(childObjs.transform.parent.gameObject);
                }
            }
            if (Move=="B")
            {
                keepMove=UMove[2];  //
                UMove[2]=RMove[8];
                keepMove2=LMove[0];
                LMove[0]=keepMove;
                keepMove=DMove[6];
                DMove[6]=keepMove2;
                RMove[8]=keepMove;
                keepMove=UMove[1];  //
                UMove[1]=RMove[5];
                keepMove2=LMove[3];
                LMove[3]=keepMove;
                keepMove=DMove[7];
                DMove[7]=keepMove2;
                RMove[5]=keepMove;
                keepMove=UMove[0];  //
                UMove[0]=RMove[2];
                keepMove2=LMove[6];
                LMove[6]=keepMove;
                keepMove=DMove[8];
                DMove[8]=keepMove2;
                RMove[2]=keepMove;

                keepMove=BMove[2];  //colturi.mij
                BMove[2]=BMove[0];
                keepMove2=BMove[8];
                BMove[8]=keepMove;
                keepMove=BMove[6];
                BMove[6]=keepMove2;
                BMove[0]=keepMove;
                keepMove=BMove[1];  //margini.mij
                BMove[1]=BMove[3];
                keepMove2=BMove[5];
                BMove[5]=keepMove;
                keepMove=BMove[7];
                BMove[7]=keepMove2;
                BMove[3]=keepMove;
            }
            else
            {
                keepMove=UMove[0];  //
                UMove[0]=LMove[6];
                keepMove2=RMove[2];
                RMove[2]=keepMove;
                keepMove=DMove[8];
                DMove[8]=keepMove2;
                LMove[6]=keepMove;
                keepMove=UMove[1];  //
                UMove[1]=LMove[3];
                keepMove2=RMove[5];
                RMove[5]=keepMove;
                keepMove=DMove[7];
                DMove[7]=keepMove2;
                LMove[3]=keepMove;
                keepMove=UMove[2];  //
                UMove[2]=LMove[0];
                keepMove2=RMove[8];
                RMove[8]=keepMove;
                keepMove=DMove[6];
                DMove[6]=keepMove2;
                LMove[0]=keepMove;

                keepMove=BMove[2];  //colturi.mij
                BMove[2]=BMove[8];
                keepMove2=BMove[0];
                BMove[0]=keepMove;
                keepMove=BMove[6];
                BMove[6]=keepMove2;
                BMove[8]=keepMove;
                keepMove=BMove[1];  //margini.mij
                BMove[1]=BMove[5];
                keepMove2=BMove[3];
                BMove[3]=keepMove;
                keepMove=BMove[7];
                BMove[7]=keepMove2;
                BMove[5]=keepMove;
            }
        }
        else//if (Move=="D_" || Move=="D")
        {
            foreach (GameObject childObjs in GameObject.FindGameObjectsWithTag("Respawn"))
            {
                if (2.99 <= childObjs.transform.parent.position.y && childObjs.transform.parent.position.y <= 3.01)
                {
                    Quaternion f = Quaternion.Euler(childObjs.transform.parent.eulerAngles.x, childObjs.transform.parent.eulerAngles.y, childObjs.transform.parent.eulerAngles.z);
                    Instantiate(childObjs.transform.parent, childObjs.transform.parent.position, f).name=childObjs.transform.parent.name;
                    Destroy(childObjs.transform.parent.gameObject);
                }
            }
            if (Move=="D")
            {
                keepMove=FMove[6];  //
                FMove[6]=LMove[6];
                keepMove2=RMove[6];
                RMove[6]=keepMove;
                keepMove=BMove[2];
                BMove[2]=keepMove2;
                LMove[6]=keepMove;
                keepMove=FMove[7];  //
                FMove[7]=LMove[7];
                keepMove2=RMove[7];
                RMove[7]=keepMove;
                keepMove=BMove[1];
                BMove[1]=keepMove2;
                LMove[7]=keepMove;
                keepMove=FMove[8];  //
                FMove[8]=LMove[8];
                keepMove2=RMove[8];
                RMove[8]=keepMove;
                keepMove=BMove[0];
                BMove[0]=keepMove2;
                LMove[8]=keepMove;

                keepMove=DMove[2];  //colturi.mij
                DMove[2]=DMove[0];
                keepMove2=DMove[8];
                DMove[8]=keepMove;
                keepMove=DMove[6];
                DMove[6]=keepMove2;
                DMove[0]=keepMove;
                keepMove=DMove[1];  //margini.mij
                DMove[1]=DMove[3];
                keepMove2=DMove[5];
                DMove[5]=keepMove;
                keepMove=DMove[7];
                DMove[7]=keepMove2;
                DMove[3]=keepMove;
            }
            else
            {
                keepMove=FMove[6];  //
                FMove[6]=RMove[6];
                keepMove2=LMove[6];
                LMove[6]=keepMove;
                keepMove=BMove[2];
                BMove[2]=keepMove2;
                RMove[6]=keepMove;
                keepMove=FMove[7];  //
                FMove[7]=RMove[7];
                keepMove2=LMove[7];
                LMove[7]=keepMove;
                keepMove=BMove[1];
                BMove[1]=keepMove2;
                RMove[7]=keepMove;
                keepMove=FMove[8];  //
                FMove[8]=RMove[8];
                keepMove2=LMove[8];
                LMove[8]=keepMove;
                keepMove=BMove[0];
                BMove[0]=keepMove2;
                RMove[8]=keepMove;

                keepMove=DMove[2];  //colturi.mij
                DMove[2]=DMove[8];
                keepMove2=DMove[0];
                DMove[0]=keepMove;
                keepMove=DMove[6];
                DMove[6]=keepMove2;
                DMove[8]=keepMove;
                keepMove=DMove[1];  //margini.mij
                DMove[1]=DMove[5];
                keepMove2=DMove[3];
                DMove[3]=keepMove;
                keepMove=DMove[7];
                DMove[7]=keepMove2;
                DMove[5]=keepMove;
            }
        }
        Obj.transform.eulerAngles = new Vector3(0,0,0);
    }

    void R()//1
    {
        if (initializeMove==false)
        {
            Obj = GameObject.Find("RObject");
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Respawn"))
                if (1.04 <= ObjectFound.transform.parent.position.x && ObjectFound.transform.parent.position.x <= 1.06)
                    ObjectFound.transform.parent.parent = Obj.transform;
            deltaRotation = Quaternion.AngleAxis(3f, Vector3.right);
            initializeMove=true;
        }
        else
        {
            Obj.transform.rotation *= deltaRotation;
            if (Obj.transform.eulerAngles.y == 180f)
            {
                Obj.transform.eulerAngles = new Vector3(90,0,0);
                initializeMove=false;
                whichMove="";
                MoveChildsAndRearrangeColors("R");
                whatDoUWannaDo="UpdateShuffleCube";
            }
        }
    }

    void R_()//2
    {
        if (initializeMove==false)
        {
            Obj = GameObject.Find("RObject");
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Respawn"))
                if (1.04 <= ObjectFound.transform.parent.position.x && ObjectFound.transform.parent.position.x <= 1.06)
                    ObjectFound.transform.parent.parent = Obj.transform;
            deltaRotation = Quaternion.AngleAxis(3f, Vector3.left);
            initializeMove=true;
        }
        else
        {
            Obj.transform.rotation *= deltaRotation;
            if (Obj.transform.eulerAngles.y == 180f)
            {
                Obj.transform.eulerAngles = new Vector3(-90,0,0);
                initializeMove=false;
                whichMove="";
                MoveChildsAndRearrangeColors("R_");
                whatDoUWannaDo="UpdateShuffleCube";
            }
        }
    }
    
    void F()//3
    {
        if (initializeMove==false)
        {
            Obj = GameObject.Find("FObject");
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Respawn"))
                if (-0.01 <= ObjectFound.transform.parent.position.z && ObjectFound.transform.parent.position.z <= 0.01)
                    ObjectFound.transform.parent.parent = Obj.transform;
            deltaRotation = Quaternion.AngleAxis(5f, Vector3.back);
            initializeMove=true;
        }
        else
        {
            Obj.transform.rotation *= deltaRotation;
            if (Obj.transform.eulerAngles.z <= 270)
            {
                Obj.transform.eulerAngles = new Vector3(0,0,-90);
                initializeMove=false;
                whichMove="";
                MoveChildsAndRearrangeColors("F");
                whatDoUWannaDo="UpdateShuffleCube";
            }
        }
    }

    void F_()//4
    {
        if (initializeMove==false)
        {
            Obj = GameObject.Find("FObject");
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Respawn"))
                if (-0.01 <= ObjectFound.transform.parent.position.z && ObjectFound.transform.parent.position.z <= 0.01)
                    ObjectFound.transform.parent.parent = Obj.transform;
            deltaRotation = Quaternion.AngleAxis(3f, Vector3.forward);
            initializeMove=true;
        }
        else
        {
            Obj.transform.rotation *= deltaRotation;
            if (Obj.transform.eulerAngles.z >= 90)
            {
                Obj.transform.eulerAngles = new Vector3(0,0,90);
                initializeMove=false;
                whichMove="";
                MoveChildsAndRearrangeColors("F_");
                whatDoUWannaDo="UpdateShuffleCube";
            }
        }
    }

    void U()//5
    {
        if (initializeMove==false)
        {
            Obj = GameObject.Find("UObject");
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Respawn"))
                if (5.09 <= ObjectFound.transform.parent.position.y && ObjectFound.transform.parent.position.y <= 5.11)
                    ObjectFound.transform.parent.parent = Obj.transform;
            deltaRotation = Quaternion.AngleAxis(3f, Vector3.up);
            initializeMove=true;
        }
        else
        {
            Obj.transform.rotation *= deltaRotation;
            if (Obj.transform.eulerAngles.y >= 90)
            {
                Obj.transform.eulerAngles = new Vector3(0,90,0);
                initializeMove=false;
                whichMove="";
                MoveChildsAndRearrangeColors("U");
                whatDoUWannaDo="UpdateShuffleCube";
            }
        }
    }

    void U_()//6
    {
        if (initializeMove==false)
        {
            Obj = GameObject.Find("UObject");
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Respawn"))
                if (5.09 <= ObjectFound.transform.parent.position.y && ObjectFound.transform.parent.position.y <= 5.11)
                    ObjectFound.transform.parent.parent = Obj.transform;
            deltaRotation = Quaternion.AngleAxis(3f, Vector3.down);
            initializeMove=true;
        }
        else
        {
            Obj.transform.rotation *= deltaRotation;
            if (Obj.transform.eulerAngles.y <= 270)
            {
                Obj.transform.eulerAngles = new Vector3(0,-90,0);
                initializeMove=false;
                whichMove="";
                MoveChildsAndRearrangeColors("U_");
                whatDoUWannaDo="UpdateShuffleCube";
            }
        }
    }

    void L()//7
    {
        if (initializeMove==false)
        {
            Obj = GameObject.Find("LObject");
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Respawn"))
                if (-1.06 <= ObjectFound.transform.parent.position.x && ObjectFound.transform.parent.position.x <= -1.04)
                    ObjectFound.transform.parent.parent = Obj.transform;
            deltaRotation = Quaternion.AngleAxis(3f, Vector3.left);
            initializeMove=true;
        }
        else
        {
            Obj.transform.rotation *= deltaRotation;
            if (Obj.transform.eulerAngles.y == 180f)
            {
                Obj.transform.eulerAngles = new Vector3(-90,0,0);
                initializeMove=false;
                whichMove="";
                MoveChildsAndRearrangeColors("L");
                whatDoUWannaDo="UpdateShuffleCube";
            }
        }
    }

    void L_()//8
    {
        if (initializeMove==false)
        {
            Obj = GameObject.Find("LObject");
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Respawn"))
                if (-1.06 <= ObjectFound.transform.parent.position.x && ObjectFound.transform.parent.position.x <= -1.04)
                    ObjectFound.transform.parent.parent = Obj.transform;
            deltaRotation = Quaternion.AngleAxis(3f, Vector3.right);
            initializeMove=true;
        }
        else
        {
            Obj.transform.rotation *= deltaRotation;
            if (Obj.transform.eulerAngles.y == 180f)
            {
                Obj.transform.eulerAngles = new Vector3(90,0,0);
                initializeMove=false;
                whichMove="";
                MoveChildsAndRearrangeColors("L_");
                whatDoUWannaDo="UpdateShuffleCube";
            }
        }
    }

    void B()//9
    {
        if (initializeMove==false)
        {
            Obj = GameObject.Find("BObject");
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Respawn"))
                if (2.09 <= ObjectFound.transform.parent.position.z && ObjectFound.transform.parent.position.z <= 2.11)
                    ObjectFound.transform.parent.parent = Obj.transform;
            deltaRotation = Quaternion.AngleAxis(3f, Vector3.forward);
            initializeMove=true;
        }
        else
        {
            Obj.transform.rotation *= deltaRotation;
            if (Obj.transform.eulerAngles.z > 90)
            {
                Obj.transform.eulerAngles = new Vector3(0,0,90);
                initializeMove=false;
                whichMove="";
                MoveChildsAndRearrangeColors("B");
                whatDoUWannaDo="UpdateShuffleCube";
            }
        }
    }

    void B_()//10
    {
        if (initializeMove==false)
        {
            Obj = GameObject.Find("BObject");
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Respawn"))
                if (2.09 <= ObjectFound.transform.parent.position.z && ObjectFound.transform.parent.position.z <= 2.11)
                    ObjectFound.transform.parent.parent = Obj.transform;
            deltaRotation = Quaternion.AngleAxis(3f, Vector3.back);
            initializeMove=true;
        }
        else
        {
            Obj.transform.rotation *= deltaRotation;
            if (Obj.transform.eulerAngles.z < 270)
            {
                Obj.transform.eulerAngles = new Vector3(0,0,-90);
                initializeMove=false;
                whichMove="";
                MoveChildsAndRearrangeColors("B_");
                whatDoUWannaDo="UpdateShuffleCube";
            }
        }
    }

    void D()//11
    {
        if (initializeMove==false)
        {
            Obj = GameObject.Find("DObject");
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Respawn"))
                if (2.99 <= ObjectFound.transform.parent.position.y && ObjectFound.transform.parent.position.y <= 3.01)
                    ObjectFound.transform.parent.parent = Obj.transform;
            deltaRotation = Quaternion.AngleAxis(3f, Vector3.down);
            initializeMove=true;
        }
        else
        {
            Obj.transform.rotation *= deltaRotation;
            if (Obj.transform.eulerAngles.y < 270)
            {
                Obj.transform.eulerAngles = new Vector3(0,-90,0);
                initializeMove=false;
                whichMove="";
                MoveChildsAndRearrangeColors("D");
                whatDoUWannaDo="UpdateShuffleCube";
            }
        }
    }

    void D_()//12
    {
        if (initializeMove==false)
        {
            Obj = GameObject.Find("DObject");
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Respawn"))
                if (2.99 <= ObjectFound.transform.parent.position.y && ObjectFound.transform.parent.position.y <= 3.01)
                    ObjectFound.transform.parent.parent = Obj.transform;
            deltaRotation = Quaternion.AngleAxis(3f, Vector3.up);
            initializeMove=true;
        }
        else
        {
            Obj.transform.rotation *= deltaRotation;
            if (Obj.transform.eulerAngles.y > 90)
            {
                Obj.transform.eulerAngles = new Vector3(0,90,0);
                initializeMove=false;
                whichMove="";
                MoveChildsAndRearrangeColors("D_");
                whatDoUWannaDo="UpdateShuffleCube";
            }
        }
    }

    void FixedUpdate()
    {
        if (whatDoUWannaDo=="FixedUpdateMoveCube")
            MoveCube();                         /*Debug.Log(Input.mousePosition);
                                                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                                                RaycastHit hit;
                                                
                                                if(Physics.Raycast (ray, out hit))
                                                {
                                                    if(hit.transform.name == "Player")
                                                    {
                                                        Debug.Log ("This is a Player");
                                                    }
                                                    else {
                                                        Debug.Log ("This isn't a Player");                
                                                    }
                                                }*/
    }

    void Update()
    {
        if (whatDoUWannaDo=="UpdateShuffleCube")
            ShuffleCube();
        else if (whatDoUWannaDo=="UpdateSolve")
            Debug.Log("aaa");
    }
}
