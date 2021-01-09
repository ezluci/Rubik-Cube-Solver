using UnityEngine;
public class MainScript : MonoBehaviour
{
    public Shuffler refShu;
    public Solver refSol;
    public CurrentMove refCrM;
    public string whatDoUWannaDo = "UpdateShuffleCube";
    public bool initializeMove = false;//sau neinitiallizat
    public float moveSpeed = 3f;
    GameObject Obj;
    Quaternion deltaRotation;
    public char[] UMove = {'w','w','w','w','w','w','w','w','w'};
    public char[] LMove = {'b','b','b','b','b','b','b','b','b'};
    public char[] FMove = {'r','r','r','r','r','r','r','r','r'};
    public char[] RMove = {'o','o','o','o','o','o','o','o','o'};
    public char[] DMove = {'y','y','y','y','y','y','y','y','y'};
    public char[] BMove = {'g','g','g','g','g','g','g','g','g'};
    char keepMove,keepMove2;

    private void Start()
    {
        
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

    public void R(string next)//1
    {
        if (!initializeMove)
        {
            if (next == "MoveAgs")
            {
                refCrM.currentMoveVar = "Move: R";
                whatDoUWannaDo = "RToMoveAgs";
            }
            Obj = GameObject.Find("RObject");
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Respawn"))
                if (1.04 <= ObjectFound.transform.parent.position.x && ObjectFound.transform.parent.position.x <= 1.06)
                    ObjectFound.transform.parent.parent = Obj.transform;
            deltaRotation = Quaternion.AngleAxis(moveSpeed, Vector3.right);
            initializeMove=true;
        }
        else
        {
            Obj.transform.rotation *= deltaRotation;
            if (Obj.transform.eulerAngles.y == 180f)
            {
                Obj.transform.eulerAngles = new Vector3(90,0,0);
                initializeMove=false;
                
                MoveChildsAndRearrangeColors("R");
                whatDoUWannaDo=next;
            }
        }
    }

    public void R_(string next)//2
    {
        if (!initializeMove)
        {
            if (next == "MoveAgs")
            {
                    refCrM.currentMoveVar = "Move: R'";
                whatDoUWannaDo = "R_ToMoveAgs";
            }
            Obj = GameObject.Find("RObject");
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Respawn"))
                if (1.04 <= ObjectFound.transform.parent.position.x && ObjectFound.transform.parent.position.x <= 1.06)
                    ObjectFound.transform.parent.parent = Obj.transform;
            deltaRotation = Quaternion.AngleAxis(moveSpeed, Vector3.left);
            initializeMove=true;
        }
        else
        {
            Obj.transform.rotation *= deltaRotation;
            if (Obj.transform.eulerAngles.y == 180f)
            {
                Obj.transform.eulerAngles = new Vector3(-90,0,0);
                initializeMove=false;
                
                MoveChildsAndRearrangeColors("R_");
                whatDoUWannaDo=next;
            }
        }
    }
    
    public void F(string next)//1
    {
        if (!initializeMove)
        {
            if (next == "MoveAgs")
            {
                refCrM.currentMoveVar = "Move: F";
                whatDoUWannaDo = "FToMoveAgs";
            }
            Obj = GameObject.Find("FObject");
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Respawn"))
                if (-0.01 <= ObjectFound.transform.parent.position.z && ObjectFound.transform.parent.position.z <= 0.01)
                    ObjectFound.transform.parent.parent = Obj.transform;
            deltaRotation = Quaternion.AngleAxis(moveSpeed, Vector3.back);
            initializeMove=true;
        }
        else
        {
            Obj.transform.rotation *= deltaRotation;
            if (Obj.transform.eulerAngles.z <= 270)
            {
                Obj.transform.eulerAngles = new Vector3(0,0,-90);
                initializeMove=false;
                
                MoveChildsAndRearrangeColors("F");
                whatDoUWannaDo=next;
            }
        }
    }

    public void F_(string next)//1
    {
        if (!initializeMove)
        {
            if (next == "MoveAgs")
            {
                refCrM.currentMoveVar = "Move: F'";
                whatDoUWannaDo = "F_ToMoveAgs";
            }
            Obj = GameObject.Find("FObject");
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Respawn"))
                if (-0.01 <= ObjectFound.transform.parent.position.z && ObjectFound.transform.parent.position.z <= 0.01)
                    ObjectFound.transform.parent.parent = Obj.transform;
            deltaRotation = Quaternion.AngleAxis(moveSpeed, Vector3.forward);
            initializeMove=true;
        }
        else
        {
            Obj.transform.rotation *= deltaRotation;
            if (Obj.transform.eulerAngles.z >= 90)
            {
                Obj.transform.eulerAngles = new Vector3(0,0,90);
                initializeMove=false;
                
                MoveChildsAndRearrangeColors("F_");
                whatDoUWannaDo=next;
            }
        }
    }

    public void U(string next)//1
    {
        if (!initializeMove)
        {
            if (next == "MoveAgs")
            {
                refCrM.currentMoveVar = "Move: U";
                whatDoUWannaDo = "UToMoveAgs";
            }
            Obj = GameObject.Find("UObject");
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Respawn"))
                if (5.09 <= ObjectFound.transform.parent.position.y && ObjectFound.transform.parent.position.y <= 5.11)
                    ObjectFound.transform.parent.parent = Obj.transform;
            deltaRotation = Quaternion.AngleAxis(moveSpeed, Vector3.up);
            initializeMove=true;
        }
        else
        {
            Obj.transform.rotation *= deltaRotation;
            if (Obj.transform.eulerAngles.y >= 90)
            {
                Obj.transform.eulerAngles = new Vector3(0,90,0);
                initializeMove=false;
                
                MoveChildsAndRearrangeColors("U");
                whatDoUWannaDo=next;
            }
        }
    }

    public void U_(string next)//1
    {
        if (!initializeMove)
        {
            if (next == "MoveAgs")
            {
                refCrM.currentMoveVar = "Move: U'";
                whatDoUWannaDo = "U_ToMoveAgs";
            }
            Obj = GameObject.Find("UObject");
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Respawn"))
                if (5.09 <= ObjectFound.transform.parent.position.y && ObjectFound.transform.parent.position.y <= 5.11)
                    ObjectFound.transform.parent.parent = Obj.transform;
            deltaRotation = Quaternion.AngleAxis(moveSpeed, Vector3.down);
            initializeMove=true;
        }
        else
        {
            Obj.transform.rotation *= deltaRotation;
            if (Obj.transform.eulerAngles.y <= 270)
            {
                Obj.transform.eulerAngles = new Vector3(0,-90,0);
                initializeMove=false;
                
                MoveChildsAndRearrangeColors("U_");
                whatDoUWannaDo=next;
            }
        }
    }

    public void L(string next)//7
    {
        if (!initializeMove)
        {
            if (next == "MoveAgs")
            {
                refCrM.currentMoveVar = "Move: L";
                whatDoUWannaDo = "LToMoveAgs";
            }
            Obj = GameObject.Find("LObject");
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Respawn"))
                if (-1.06 <= ObjectFound.transform.parent.position.x && ObjectFound.transform.parent.position.x <= -1.04)
                    ObjectFound.transform.parent.parent = Obj.transform;
            deltaRotation = Quaternion.AngleAxis(moveSpeed, Vector3.left);
            initializeMove=true;
        }
        else
        {
            Obj.transform.rotation *= deltaRotation;
            if (Obj.transform.eulerAngles.y == 180f)
            {
                Obj.transform.eulerAngles = new Vector3(-90,0,0);
                initializeMove=false;
                
                MoveChildsAndRearrangeColors("L");
                whatDoUWannaDo=next;
            }
        }
    }

    public void L_(string next)//8
    {
        if (!initializeMove)
        {
            if (next == "MoveAgs")
            {
                refCrM.currentMoveVar = "Move: L'";
                whatDoUWannaDo = "L_ToMoveAgs";
            }
            Obj = GameObject.Find("LObject");
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Respawn"))
                if (-1.06 <= ObjectFound.transform.parent.position.x && ObjectFound.transform.parent.position.x <= -1.04)
                    ObjectFound.transform.parent.parent = Obj.transform;
            deltaRotation = Quaternion.AngleAxis(moveSpeed, Vector3.right);
            initializeMove=true;
        }
        else
        {
            Obj.transform.rotation *= deltaRotation;
            if (Obj.transform.eulerAngles.y == 180f)
            {
                Obj.transform.eulerAngles = new Vector3(90,0,0);
                initializeMove=false;
                
                MoveChildsAndRearrangeColors("L_");
                whatDoUWannaDo=next;
            }
        }
    }

    public void B(string next)//9
    {
        if (!initializeMove)
        {
            if (next == "MoveAgs")
            {
                refCrM.currentMoveVar = "Move: B";
                whatDoUWannaDo = "BToMoveAgs";
            }
            Obj = GameObject.Find("BObject");
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Respawn"))
                if (2.09 <= ObjectFound.transform.parent.position.z && ObjectFound.transform.parent.position.z <= 2.11)
                    ObjectFound.transform.parent.parent = Obj.transform;
            deltaRotation = Quaternion.AngleAxis(moveSpeed, Vector3.forward);
            initializeMove=true;
        }
        else
        {
            Obj.transform.rotation *= deltaRotation;
            if (Obj.transform.eulerAngles.z > 90)
            {
                Obj.transform.eulerAngles = new Vector3(0,0,90);
                initializeMove=false;
                
                MoveChildsAndRearrangeColors("B");
                whatDoUWannaDo=next;
            }
        }
    }

    public void B_(string next)//10
    {
        if (!initializeMove)
        {
            if (next == "MoveAgs")
            {
                refCrM.currentMoveVar = "Move: B'";
                whatDoUWannaDo = "B_ToMoveAgs";
            }
            Obj = GameObject.Find("BObject");
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Respawn"))
                if (2.09 <= ObjectFound.transform.parent.position.z && ObjectFound.transform.parent.position.z <= 2.11)
                    ObjectFound.transform.parent.parent = Obj.transform;
            deltaRotation = Quaternion.AngleAxis(moveSpeed, Vector3.back);
            initializeMove=true;
        }
        else
        {
            Obj.transform.rotation *= deltaRotation;
            if (Obj.transform.eulerAngles.z < 270)
            {
                Obj.transform.eulerAngles = new Vector3(0,0,-90);
                initializeMove=false;
                
                MoveChildsAndRearrangeColors("B_");
                whatDoUWannaDo=next;
            }
        }
    }

    public void D(string next)//11
    {
        if (!initializeMove)
        {
            if (next == "MoveAgs")
            {
                refCrM.currentMoveVar = "Move: D";
                whatDoUWannaDo = "DToMoveAgs";
            }
            Obj = GameObject.Find("DObject");
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Respawn"))
                if (2.99 <= ObjectFound.transform.parent.position.y && ObjectFound.transform.parent.position.y <= 3.01)
                    ObjectFound.transform.parent.parent = Obj.transform;
            deltaRotation = Quaternion.AngleAxis(moveSpeed, Vector3.down);
            initializeMove=true;
        }
        else
        {
            Obj.transform.rotation *= deltaRotation;
            if (Obj.transform.eulerAngles.y < 270)
            {
                Obj.transform.eulerAngles = new Vector3(0,-90,0);
                initializeMove=false;
                
                MoveChildsAndRearrangeColors("D");
                whatDoUWannaDo=next;
            }
        }
    }

    public void D_(string next)//12
    {
        if (!initializeMove)
        {
            if (next == "MoveAgs")
            {
                refCrM.currentMoveVar = "Move: D'";
                whatDoUWannaDo = "D_ToMoveAgs";
            }
            Obj = GameObject.Find("DObject");
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Respawn"))
                if (2.99 <= ObjectFound.transform.parent.position.y && ObjectFound.transform.parent.position.y <= 3.01)
                    ObjectFound.transform.parent.parent = Obj.transform;
            deltaRotation = Quaternion.AngleAxis(moveSpeed, Vector3.up);
            initializeMove=true;
        }
        else
        {
            Obj.transform.rotation *= deltaRotation;
            if (Obj.transform.eulerAngles.y > 90)
            {
                Obj.transform.eulerAngles = new Vector3(0,90,0);
                initializeMove=false;
                
                MoveChildsAndRearrangeColors("D_");
                whatDoUWannaDo=next;
            }
        }
    }

    void FixedUpdate()
    {
        if (whatDoUWannaDo=="FixedUpdateMoveCubeForShuffle")
            refShu.MoveCubeForShuffle();                         /*Debug.Log(Input.mousePosition);
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
        else if (whatDoUWannaDo == "RToMoveAgs")
        {
			R("MoveAgs");
		}
		else if (whatDoUWannaDo == "R_ToMoveAgs")
		{
			R_("MoveAgs");
		}
		else if (whatDoUWannaDo == "FToMoveAgs")
		{
			F("MoveAgs");
		}
		else if (whatDoUWannaDo == "F_ToMoveAgs")
		{
			F_("MoveAgs");
		}
		else if (whatDoUWannaDo == "UToMoveAgs")
		{
			U("MoveAgs");
		}
		else if (whatDoUWannaDo == "U_ToMoveAgs")
		{
			U_("MoveAgs");
		}
		else if (whatDoUWannaDo == "LToMoveAgs")
		{
			L("MoveAgs");
		}
		else if (whatDoUWannaDo == "L_ToMoveAgs")
		{
			L_("MoveAgs");
		}
		else if (whatDoUWannaDo == "BToMoveAgs")
		{
			B("MoveAgs");
		}
		else if (whatDoUWannaDo == "B_ToMoveAgs")
		{
			B_("MoveAgs");
		}
		else if (whatDoUWannaDo == "DToMoveAgs")
		{
			D("MoveAgs");
		}
		else if (whatDoUWannaDo == "D_ToMoveAgs")
		{
			D_("MoveAgs");
		}
    }

    void Update()
    {
        if (whatDoUWannaDo == "UpdateShuffleCube")
		{
			refShu.ShuffleCube();
		}
		else if (whatDoUWannaDo == "MoveAgs")
		{
			refSol.MoveAgs();
		}
    }










}
